using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rainfall.Api.Application.Common.Interfaces;
using Rainfall.Api.Application.Common.Models;
using Rainfall.Api.Application.Reading.Queries.GetParticularStation;
using RestSharp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rainfall.Api.Infrastructure.RainfallReading;
public class RainfallReadingExternal : IRainfallReadingExternal
{
    public async Task<ParticularStationDto> GetParticularStationById(long stationid)
    {
        var client = new RestClient($"https://environment.data.gov.uk/flood-monitoring/id/stations/{stationid}");
        var request = new RestRequest();
        RestResponse response = await client.ExecuteAsync(request);

        //return new  { 
        //    content = ""
        //};
    }
}
