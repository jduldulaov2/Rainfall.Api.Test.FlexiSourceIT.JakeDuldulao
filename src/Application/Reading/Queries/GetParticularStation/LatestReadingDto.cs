using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rainfall.Api.Application.Reading.Queries.GetParticularStation;
public class LatestReadingDto
{
    [JsonProperty(PropertyName = "@id")]
    public string? Id { get; set; }

    [JsonProperty(PropertyName = "date")]
    public string? Date { get; set; }

    [JsonProperty(PropertyName = "dateTime")]
    public string? DateTime { get; set; }

    [JsonProperty(PropertyName = "measure")]
    public string? Measure { get; set; }

    [JsonProperty(PropertyName = "value")]
    public decimal Value { get; set; }
}
