using Imi.Project.Blazor.Core.MemoryGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.MemoryGame.Services
{
    public class MemoryService : IMemoryService
    {
        private List<MemoryCardModel> currentSelection = new List<MemoryCardModel>();

        private StatsModel stats = new StatsModel();

        private readonly static ICollection<string> _images = new List<string>
        {
            "/images/Memory/Memory1.jpg",
            "/images/Memory/Memory1.jpg",
            "/images/Memory/Memory2.jpg",
            "/images/Memory/Memory2.jpg",
            "/images/Memory/Memory3.jpg",
            "/images/Memory/Memory3.jpg",
            "/images/Memory/Memory4.jpg",
            "/images/Memory/Memory4.jpg",
            "/images/Memory/Memory5.jpg",
            "/images/Memory/Memory5.jpg",
            "/images/Memory/Memory6.jpg",
            "/images/Memory/Memory6.jpg",
            "/images/Memory/Memory7.jpg",
            "/images/Memory/Memory7.jpg",
            "/images/Memory/Memory8.jpg",
            "/images/Memory/Memory8.jpg",
            "/images/Memory/Memory9.jpg",
            "/images/Memory/Memory9.jpg",
            "/images/Memory/Memory10.jpg",
            "/images/Memory/Memory10.jpg",
        };

        public List<MemoryCardModel> GetMemoryCards()
        {
            List<MemoryCardModel> cards = new List<MemoryCardModel>();
            List<string> images = GetShuffledImages();

            foreach (var image in images)
            {
                MemoryCardModel card = new MemoryCardModel { ActualImage = image };
                card.CurrentImage = card.CoverImage;
                cards.Add(card);
            }

            return cards;
        }

        public async Task HandleSelection(MemoryCardModel card)
        {
            card.CurrentImage = card.ActualImage;
            currentSelection.Add(card);

            if (currentSelection.Count == 2)
            {
                if (IsPair(currentSelection))
                {
                    HandleCorrect();
                }
                else
                {
                    await HandleMistake(currentSelection);
                }
                currentSelection.Clear();
            }
        }

        public StatsModel GetStats()
        {
            return stats;
        }

        //ik retourneer void omdat ik op dit moment nog niet weet of ik iets zal retourneren of niet.
        public void EndGame(bool isVictory)
        {
            throw new NotImplementedException();
        }

        private async Task HandleMistake(List<MemoryCardModel> currentSelection)
        {
            MemoryCardModel firstCard = currentSelection.FirstOrDefault();
            MemoryCardModel secondCard = currentSelection.LastOrDefault();

            await Task.Delay(500); //Small delay so the player can see the cards that he selected before they turn around again
            firstCard.CurrentImage = firstCard.CoverImage;
            secondCard.CurrentImage = secondCard.CoverImage;
            stats.Lives--;
        }

        private void HandleCorrect()
        {
            throw new NotImplementedException();
        }

        private static bool IsPair(List<MemoryCardModel> currentSelection)
        {
            if (currentSelection.FirstOrDefault().ActualImage == currentSelection.LastOrDefault().ActualImage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<string> GetShuffledImages()
        {
            Random random = new Random();

            List<string> shuffledImages = _images.OrderBy(a => random.Next()).ToList();

            return shuffledImages;
        }
    }
}
