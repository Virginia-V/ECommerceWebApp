using ECommerce.Common.Dtos;
using System.Net;

namespace ECommerce.Common.Exceptions
{
    public class ApiException : Exception
    {
        public HttpStatusCode StatusCode { get; }

        public ApiException(HttpStatusCode statusCode, string message, AuthResult authResult = null) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
