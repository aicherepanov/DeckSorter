using DeckSorter.Domain.Models;
using System.Collections.Generic;

namespace DeckSorter.Domain.Services
{
    public interface IDecksService
    {
        List<Deck> Decks { get; }
        Deck Get(string name);
        bool Create(string name);
        void UpdateDeck(Deck deck);
        void Delete(string deck);
        void ShuffleDeck(Deck deck);
        List<string> GetDecksList();
    }
}