using DeckSorter.Api.Models;
using System.Collections.Generic;

namespace DeckSorter.Api.Services
{
    public interface IDecksService
    {
        List<Deck> Decks { get; }

        Deck GetDeckByName(string deckName);
    }
}