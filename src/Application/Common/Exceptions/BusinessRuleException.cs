namespace Rainfall.Api.Application.Common.Exceptions;

public class BusinessRuleException : Exception
{
    public BusinessRuleException() : base() { }

    public BusinessRuleException(string message) : base(message) { }
}
