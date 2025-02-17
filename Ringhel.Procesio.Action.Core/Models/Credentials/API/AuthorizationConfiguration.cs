﻿namespace Ringhel.Procesio.Action.Core.Models.Credentials.API;

public class AuthorizationConfiguration
{
    public AuthorizationType Type { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string ApiKey { get; set; }

    public string ApiValue { get; set; }

    public string Token { get; set; }

    public ClientApiKeyLocation ApiKeyLocation { get; set; }

    public ClientApiKeyLocation BasicAuthLocation { get; set; }

    public string CertificateFile { get; set; }
    public string CertificatePassword { get; set; }
}
