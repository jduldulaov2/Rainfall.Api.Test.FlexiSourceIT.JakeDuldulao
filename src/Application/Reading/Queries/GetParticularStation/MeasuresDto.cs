using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rainfall.Api.Application.Reading.Queries.GetParticularStation;
public class MeasuresDto
{
    [JsonProperty(PropertyName = "@id")]
    public string? Id { get; set; }

    [JsonProperty(PropertyName = "label")]
    public string? Label { get; set; }

    [JsonProperty(PropertyName = "latestReading")]
    public LatestReadingDto? LatestReading { get; set; }

    [JsonProperty(PropertyName = "notation")]
    public string? Notation { get; set; }

    [JsonProperty(PropertyName = "parameter")]
    public string? Parameter { get; set; }

    [JsonProperty(PropertyName = "period")]
    public int? Period { get; set; }

    [JsonProperty(PropertyName = "qualifier")]
    public string? Qualifier { get; set; }

    [JsonProperty(PropertyName = "station")]
    public string? Station { get; set; }

    [JsonProperty(PropertyName = "stationReference")]
    public string? StationReference { get; set; }

    [JsonProperty(PropertyName = "type")]
    public string[]? Type { get; set; }

    [JsonProperty(PropertyName = "unit")]
    public string? Unit { get; set; }

    [JsonProperty(PropertyName = "unitName")]
    public string? UnitName { get; set; }

    [JsonProperty(PropertyName = "valueType")]
    public string? ValueType { get; set; }
}
