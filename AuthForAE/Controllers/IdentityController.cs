using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AuthForAE.Controllers
{
    public class IdentityController : ControllerBase
    {
        private const string TokenSecret = "AOA";
        private static readonly TimeSpan TokenLifetime = TimeSpan.FromHours(1);

        [HttpPost("token")]
         public IActionResult GenerateToken()
        {
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = 
            }
        }
    }
}
