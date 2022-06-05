using System.IO;

namespace Imi.Project.Blazor.Core.CRUD.Models.ViewModels
{
    public class ImageFile
    {
        public string Name { get; set; }
        public string ContentType { get; set; }
        public Stream Data { get; set; }
        public long Size { get; set; }
    }
}
