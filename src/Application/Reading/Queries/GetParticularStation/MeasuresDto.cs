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
}
