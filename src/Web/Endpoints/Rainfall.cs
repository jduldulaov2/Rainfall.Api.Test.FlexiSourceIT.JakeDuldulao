using Rainfall.Api.Application.Common.Models;
using Rainfall.Api.Application.Reading.Queries.GetParticularStation;

namespace Rainfall.Api.Web.Endpoints;

public class Rainfall : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetParticularStation, "id/{StationId}/readings");
    }

    public async Task<string> GetParticularStation(ISender sender, [AsParameters] ParticularStationQuery query)
    {
        return await sender.Send(query);
    }

}
