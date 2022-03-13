using System.Collections.Generic;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public interface IMemoryService
    {
        List<string> GetShuffledImages();
    }
}