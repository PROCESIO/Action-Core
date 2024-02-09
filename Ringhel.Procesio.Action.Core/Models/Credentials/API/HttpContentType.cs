namespace Ringhel.Procesio.Action.Core.Models.Credentials.API
{
    public enum HttpContentType
    {
        None = 0,
        /// <summary>
        /// The body should be a Json object
        /// </summary>
        Json = 1,
        /// <summary>
        /// The body requires a Dictionary<string,string> object
        /// </summary>
        FormData = 2,
        /// <summary>
        /// The body requires a Dictionary<string,string> object
        /// </summary>
        FormUrlEncoded = 3,
        /// <summary>
        /// The body has to be of type Action.Core.FileModel
        /// </summary>
        FileMultipart = 4,
        /// <summary>
        /// The body should be plain text
        /// </summary>
        Text = 5,
        /// <summary>
        /// The body should be a Html object
        /// </summary>
        Html = 6,
        /// <summary>
        /// The body should be a Xml object
        /// </summary>
        Xml = 7,
        /// <summary>
        /// The body should be a JavaScript object
        /// </summary>
        JavaScript = 8,
    }
}
