﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rainfall.Api.Application.Reading.Queries.GetParticularStation;
public class ParticularStationDto
{
    [JsonProperty(PropertyName = "@context")]
    public string? @context { get; set; }
    public MetaDto? meta {  get; set; }

    public ItemsDto? items { get; set; }
}
