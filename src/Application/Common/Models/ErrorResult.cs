using System.Text.Json;
using Rainfall.Api.Application.Common.Models.Enums;

namespace Rainfall.Api.Application.Common.Models;

public class ErrorResult
{
    public ErrorResult() => ResultType = ResultType.Error;

    public ResultType ResultType { get; set; }
    public string Message { get; set; } = null!;

    public override string ToString() => JsonSerializer.Serialize(this, DefaultSerializerOptions());

    private static JsonSerializerOptions DefaultSerializerOptions() => new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
}
