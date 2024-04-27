using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rainfall.Api.Application.Common.Models.Enums;
using Rainfall.Api.Application.Common.Models;
using Rainfall.Api.Application.Common.Interfaces;

namespace Rainfall.Api.Application.Reading.Queries.GetParticularStation;

public record ParticularStationQuery : IRequest<string>
{
    public long StationId { get; init; }
}

public class GetSystemEnvironmentHandler : IRequestHandler<ParticularStationQuery, string>
{
    private readonly IRainfallReadingExternal _rainfall;

    public GetSystemEnvironmentHandler(IRainfallReadingExternal rainfall)
    {
        _rainfall = rainfall;
    }

    public async Task<string> Handle(ParticularStationQuery request, CancellationToken cancellationToken)
    {
        var result = await _rainfall.GetParticularStationById(request.StationId);

        return result;

    }
}
