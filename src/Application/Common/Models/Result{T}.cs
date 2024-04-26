
using Rainfall.Api.Application.Common.Models.Enums;

namespace Rainfall.Api.Application.Common.Models;

public class Result<T>
{
    public required T Data { get; set; }
    public required string Message { get; set; }
    public ResultType ResultType { get; set; }

    public static Result<T> Success(T data, string message)
    {
        return new Result<T>
        {
            Data = data,
            Message = message,
            ResultType = ResultType.Success,
        };
    }

    
}

