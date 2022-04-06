using Imi.Project.Blazor.Core.MemoryGame.Models;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Core.MemoryGame.Services
{
    public interface IMemoryService
    {
        List<MemoryCardModel> GetMemoryCards();
        void HandleSelection(MemoryCardModel card);
        StatsModel GetStats();
        void EndGame(bool isVictory);
    }
}