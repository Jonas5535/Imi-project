using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public class MemoryService
    {
        private static ICollection<string> _images = new List<string>
        {
            "/images/Memory/Memory1.jpg",
            "/images/Memory/Memory2.jpg",
            "/images/Memory/Memory3.jpg",
            "/images/Memory/Memory4.jpg",
            "/images/Memory/Memory5.jpg",
            "/images/Memory/Memory6.jpg",
            "/images/Memory/Memory7.jpg",
            "/images/Memory/Memory8.jpg",
            "/images/Memory/Memory9.jpg",
            "/images/Memory/Memory10.jpg",
        };
    }
}
