using Imi.Project.Blazor.Core.CRUD.Models;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public interface IMemoryService
    {
        List<MemoryCardModel> GetMemoryCards();
    }
}