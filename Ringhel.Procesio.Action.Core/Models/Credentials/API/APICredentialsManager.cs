﻿using System.Net.Http;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.API
{
    public class APICredentialsManager
    {
        public APICredentialsConfiguration CredentialConfig { get; set; }

        public IHttpClient Client { get; set; }
    }
}
