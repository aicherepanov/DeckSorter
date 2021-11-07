using DeckSorter.Domain.Models;
using System;
using System.Collections.Generic;

namespace DeckSorter.Domain.Repositories
{
    public interface IDecksRepository : IDisposable
    {
        IEnumerable<Deck> GetDecksList();
        Deck GetDeck(string name);
        void CreateDeck(Deck deck);
        void UpdateDeck(Deck deck);
        void DeleteDeck(Deck deck);
        void ShuffleDeck(Deck deck);
    }
}
