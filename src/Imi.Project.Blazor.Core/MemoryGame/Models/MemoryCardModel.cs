namespace Imi.Project.Blazor.Core.MemoryGame.Models
{
    public class MemoryCardModel
    {
        public string CoverImage { get; } = "/images/Memory/CardCover.png";
        public string ActualImage { get; set; }
        public string CurrentImage { get; set; }
        public bool MatchFound { get; set; } = false;
    }
}