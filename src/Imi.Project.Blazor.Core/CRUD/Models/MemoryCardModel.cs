namespace Imi.Project.Blazor.Core.CRUD.Models
{
    public class MemoryCardModel
    {
        public string CoverImage { get; } = "/images/Memory/CardCover.png";
        public string ActualImage { get; set; }
        public string CurrentImage { get; set; }
    }
}