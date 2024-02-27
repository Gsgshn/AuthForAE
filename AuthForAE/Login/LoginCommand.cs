using MediatR;
using System.Windows.Input;

namespace AuthForAE.Login
{
   public record LoginCommand(string Email, string Password) : IRequest<LoginResult>;
   
}
