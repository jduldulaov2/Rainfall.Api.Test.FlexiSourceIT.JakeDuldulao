using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rainfall.Api.Application.Common.Interfaces;
using Rainfall.Api.Application.Common.Models;
using Rainfall.Api.Application.Common.Models.Enums;
using Rainfall.Api.Application.Reading.Queries.GetParticularStation;
using RestSharp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rainfall.Api.Infrastructure.RainfallReading;
public class RainfallReadingExternal : IRainfallReadingExternal
{
    public async Task<Result<ParticularStationDto>> GetParticularStationById(long stationid)
    {
        var client = new RestClient($"https://environment.data.gov.uk/flood-monitoring/id/stations/{stationid}");
        var request = new RestRequest();
        RestResponse response = await client.ExecuteAsync(request);

        if (response.StatusCode == HttpStatusCode.OK)
        {
            request.AddHeader("Accept", "application/json");

            ParticularStationDto? rainFallObj = JsonConvert.DeserializeObject<ParticularStationDto>(response.Content!);

            return new()
            {
                Data = rainFallObj!,
                Message = "Records Found.",
                ResultType = ResultType.Success,
            };
        }

        return new()
        {
            Data = new ParticularStationDto { },
            Message = "Rainfall Record/s Not Found.",
            ResultType = ResultType.Error,
        };

    }
}
