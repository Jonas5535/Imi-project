using System.IO;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class ImageFile
    {
        public string Name { get; set; }
        public string ContentType { get; set; }
        public Stream Data { get; set; }
    }
}
