using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [ApiController]
    [Authorize]
    public abstract class AppBaseController : ControllerBase
    {

    }
}
