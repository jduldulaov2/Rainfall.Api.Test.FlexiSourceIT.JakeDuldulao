using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rainfall.Api.Application.Common.Interfaces;
using RestSharp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rainfall.Api.Infrastructure.RainfallReading;
public class RainfallReadingExternal : IRainfallReadingExternal
{
    public async Task<string> GetParticularStationById(long stationid)
    {
        var client = new RestClient($"https://environment.data.gov.uk/flood-monitoring/id/stations/{stationid}");
        var request = new RestRequest();
        RestResponse response = await client.ExecuteAsync(request);

        //to do here

        return "to do here";
    }
}
