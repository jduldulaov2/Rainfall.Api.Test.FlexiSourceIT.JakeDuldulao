namespace Rainfall.Api.Application.Common.Interfaces;
public interface IPassword
{
    Task<string> GeneratePasswordAsync(int lowercase, int uppercase, int numerics);
}
