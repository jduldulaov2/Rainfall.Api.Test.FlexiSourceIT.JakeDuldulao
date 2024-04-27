using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rainfall.Api.Application.Reading.Queries.GetParticularStation;
public class MetaDto
{
    [JsonProperty(PropertyName = "publisher")]
    public string? Publisher { get; set; }

    [JsonProperty(PropertyName = "license")]
    public string? License { get; set; }

    [JsonProperty(PropertyName = "documentation")]
    public string? Documentation { get; set; }

    [JsonProperty(PropertyName = "version")]
    public string? Version { get; set; }

    [JsonProperty(PropertyName = "comment")]
    public string? Comment { get; set; }

    [JsonProperty(PropertyName = "hasFormat")]
    public string[]? hasFormat { get; set; }
}
