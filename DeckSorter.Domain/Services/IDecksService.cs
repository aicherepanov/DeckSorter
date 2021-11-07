using DeckSorter.Domain.Models;
using System.Collections.Generic;

namespace DeckSorter.Domain.Services
{
    public interface IDecksService
    {
        List<Deck> Decks { get; }

        Deck GetDeckByName(string deckName);
    }
}