using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Extensions
{
    public class ErrorHandlerMiddleware : Exception
    {
        public int ErrorCode { get; }
        public string UserFriendlyMessage { get; }

        public ErrorHandlerMiddleware(string message, int errorCode, string userFriendlyMessage = null)
            : base(message)
        {
            ErrorCode = errorCode;
            UserFriendlyMessage = userFriendlyMessage ?? message;
        }

        // Optionally, you can override the ToString() method if you want to include additional details when the exception is logged.
        public override string ToString()
        {
            return $"Error Code: {ErrorCode}, Message: {Message}";
        }
    }
}
