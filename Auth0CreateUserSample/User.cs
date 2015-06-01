using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth0CreateUserSample
{
    public class User
    {
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string connection { get; set; }
        public Dictionary<string, string> app_metadata { get; set; }
    }
}
