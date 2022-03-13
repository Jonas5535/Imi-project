using Imi.Project.Blazor.Core.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public class MemoryService : IMemoryService
    {
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
                cards.Add(card);
            }

            return cards;
        }

        private static List<string> GetShuffledImages()
        {
            Random random = new Random();

            List<string> shuffledImages = _images.OrderBy(a => random.Next()).ToList();

            return shuffledImages;
        }
    }
}
