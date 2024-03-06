using Microsoft.AspNetCore.Identity;

namespace AuthForAE.Controllers
{
    public interface IJwtProvider
    {
        string Generate(IdentityUser user);
    }
}
