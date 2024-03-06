using AuthForAE.Controllers;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Windows.Input;

namespace AuthForAE.Login
{
    internal sealed class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<IdentityUser> _userManager;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<IdentityUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        

        async Task<string> IRequestHandler<LoginCommand, string>.Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            string email = request.Email;

            IdentityUser user = await _userManager.FindByEmailAsync(email);


            string token = _jwtProvider.Generate(user);



            return token;
        }
    }
}
