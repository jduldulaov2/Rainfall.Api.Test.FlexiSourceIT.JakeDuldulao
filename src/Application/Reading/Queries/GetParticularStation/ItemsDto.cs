using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rainfall.Api.Application.Reading.Queries.GetParticularStation;
public class ItemsDto
{
    [JsonProperty(PropertyName = "@id")]
    public string? Id { get; set; }

    public string? eaRegionName { get; set; }

    public string? easting { get; set; }

    public string? gridReference { get; set; }

    public string? label { get; set; }

    public string? lat { get; set; }

    [JsonProperty(PropertyName = "long")]
    public string? longitude { get; set; }
}
