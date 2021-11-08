using DeckSorter.Domain.Models;
using System.Collections.Generic;

namespace DeckSorter.Domain.Repositories
{
    public interface IDecksRepository
    {
        IEnumerable<Deck> GetDecksList();
        Deck Get(string name);
        void Create(Deck deck);
        void Update(Deck deck);
        void Delete(Deck deck);
        void Shuffle(Deck deck);
    }
}
