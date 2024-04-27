using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall.Api.Application.Common.Interfaces;
public interface IRainfallReadingExternal
{
    Task<string> GetParticularStationById(long id);
}
