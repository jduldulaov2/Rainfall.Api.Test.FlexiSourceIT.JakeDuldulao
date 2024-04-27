using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall.Api.Application.Reading.Queries.GetParticularStation;
public class ParticularStationQueryValidator : AbstractValidator<ParticularStationQuery>
{
    public ParticularStationQueryValidator()
    {
        RuleFor(v => v.StationId)
            .NotEmpty();
    }
}

