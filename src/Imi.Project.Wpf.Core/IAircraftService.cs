﻿using Imi.Project.Wpf.Core.ApiModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core
{
    public interface IAircraftService
    {
        Task<ApiBaseResponse<IEnumerable<ApiAircraftListResponse>>> ListAllAsync();
    }
}