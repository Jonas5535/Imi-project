using Imi.Project.Blazor.Core.MemoryGame.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.MemoryGame.Services
{
    public interface IMemoryService
    {
        List<MemoryCardModel> GetMemoryCards();
        Task HandleSelection(MemoryCardModel card);
        StatsModel GetStats();
        MessageBoxModel EndGame(bool isVictory);
    }
}