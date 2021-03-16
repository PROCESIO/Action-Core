using System;
using System.Collections.Generic;
using System.Text;

namespace Ringhel.Procesio.Action.Core.Credentials
{
    public class ApiCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string BaseUrl { get; set; }
        public string AuthenticationType { get; set; }
        public string ApiKeyLocation { get; set; }
    }
}
