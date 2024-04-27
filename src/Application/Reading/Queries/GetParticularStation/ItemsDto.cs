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

    [JsonProperty(PropertyName = "eaRegionName")]
    public string? EARegionName { get; set; }

    [JsonProperty(PropertyName = "easting")]
    public string? EAsting { get; set; }

    [JsonProperty(PropertyName = "gridReference")]
    public string? GridReference { get; set; }

    [JsonProperty(PropertyName = "label")]
    public string? LabelItem { get; set; }

    [JsonProperty(PropertyName = "lat")]
    public string? Latitude { get; set; }

    [JsonProperty(PropertyName = "long")]
    public string? longitude { get; set; }

    [JsonProperty(PropertyName = "measures")]
    public List<MeasuresDto>? Measures { get; set; }

    [JsonProperty(PropertyName = "northing")]
    public string? Northing { get; set; }

    [JsonProperty(PropertyName = "notation")]
    public string? Notation { get; set; }

    [JsonProperty(PropertyName = "stationReference")]
    public string? StationReference { get; set; }

    [JsonProperty(PropertyName = "type")]
    public string? Type { get; set; }
}
