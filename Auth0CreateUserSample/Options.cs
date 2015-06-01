using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace Auth0CreateUserSample
{
    class Options
    {
        [Option('e', "email_address", Required = true,
          HelpText = "The email address corresponding to the user you wish to create")]
        public string Email { get; set; }

        [Option('u', "username", Required = true,
          HelpText = "The username corresponding to the user you wish to create")]
        public string Username { get; set; }

        [Option('d', "domain", Required = true,
          HelpText = "The Auth0 domain that you wish to create the user on")]
        public string Domain { get; set; }

        [Option('t', "token", Required = true,
          HelpText = "A token with 'create:users' scope from your Auth0 account. (Generatable at https://auth0.com/docs/api/v2#!/Users/post_users)")]
        public string Token { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
