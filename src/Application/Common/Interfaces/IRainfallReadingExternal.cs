using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rainfall.Api.Application.Common.Models;
using Rainfall.Api.Application.Reading.Queries.GetParticularStation;

namespace Rainfall.Api.Application.Common.Interfaces;
public interface IRainfallReadingExternal
{
    Task<Result<ParticularStationDto>> GetParticularStationById(long stationid);
}
