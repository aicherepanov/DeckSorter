using DeckSorter.Domain.Models;

namespace DeckSorter.Domain.Services
{
    public interface IShufflerService
    {
        public void Shuffle(Deck deck);
    }
}
