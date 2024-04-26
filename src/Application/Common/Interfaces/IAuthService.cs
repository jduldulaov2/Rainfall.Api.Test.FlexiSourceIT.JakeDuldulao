namespace Rainfall.Api.Application.Common.Interfaces;

public interface IAuthService
{
    Task<bool> SignIn(string username, string password);
    Task SignOut();
}
