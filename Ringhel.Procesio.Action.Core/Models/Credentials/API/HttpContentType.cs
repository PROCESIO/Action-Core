using System;
using System.Collections.Generic;
using System.Text;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.API
{
    public enum HttpContentType
    {
        None = 0,
        Json = 1,
        FormData = 2,
        FormUrlEncoded = 3,
        FileMultipart = 4
    }
}
