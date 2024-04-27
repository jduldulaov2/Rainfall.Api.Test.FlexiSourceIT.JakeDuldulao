using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall.Api.Application.Reading.Queries.GetParticularStation;
public class MetaDto
{
    public string? publisher { get; set; }

    public string? license { get; set; }

    public string? documentation { get; set; }

    public string? version { get; set; }

    public string? comment { get; set; }

    public string[]? hasFormat { get; set; }
}
