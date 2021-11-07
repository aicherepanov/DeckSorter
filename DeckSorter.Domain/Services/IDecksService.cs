using DeckSorter.Domain.Models;
using System.Collections.Generic;

namespace DeckSorter.Domain.Services
{
    public interface IDecksService
    {
        List<Deck> Decks { get; }
        Deck GetDeck(string name);
        Deck CreateDeck(string name);
        void UpdateDeck(Deck deck);
        void DeleteDeck(Deck deck);
        void ShuffleDeck(Deck deck);
    }
}