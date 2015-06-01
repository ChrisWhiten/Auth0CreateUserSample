using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Auth0CreateUserSample
{
    class Program
    {
        private static string CreateUser(string username, string email, string domain, string token)
        {
            using (var client = new HttpClient())
            {
                User u = new User
                {
                    email = email,
                    username = username,
                    password = "test",
                    connection = "Username-Password-Authentication",
                    app_metadata = new Dictionary<string, string> 
                    {
                        {"companyId", "987"},
                        {"fakeId", "447"}
                    }
                };

                var postBody = JsonConvert.SerializeObject(u);
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                var response = client.PostAsync(
                    "https://" + domain + "/api/v2/users", 
                    new StringContent(postBody, Encoding.UTF8, "application/json")).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;

                return responseString;
            }
        }
        static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                string response = CreateUser(
                    options.Username,
                    options.Email,
                    options.Domain,
                    options.Token);

                Console.WriteLine("\n" + response);
                Console.Write("\nUser creation completed.  Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(@"Invalid command line arguments.  Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
