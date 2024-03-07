namespace Ringhel.Procesio.Action.Core;

public class CustomErrorException : Exception
{
    public int ErrorCode { get; set; }

    public CustomErrorException(
        int errorCode,
        string message) : base(message)
    {
        ErrorCode = errorCode;
    }

    public CustomErrorException(
        int errorCode,
        string message,
        Exception innerException) : base(message, innerException)
    {
        ErrorCode = errorCode;
    }
}