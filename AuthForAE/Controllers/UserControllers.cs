using AuthForAE.Login;
using Microsoft.AspNetCore.Mvc;

namespace AuthForAE.Controllers
{
    public class UserControllers
    {

        public async Task<IActionResult> LoginUser([FromBody] LoginRequest request, CancellationToken cancellationToken)
        {

        }
    }
}
