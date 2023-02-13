using ECommerce.Common.Dtos;
using System.Net;

namespace ECommerce.Common.Exceptions
{
    public class AuthException : ApiException
    {
        public AuthException(AuthResult authResult) : base(HttpStatusCode.BadRequest, authResult.Errors.FirstOrDefault(), authResult)
        {
        }
    }
}
