using DeckSorter.Domain.Models;
using DeckSorter.Domain.Services;
using System.Collections.Generic;

namespace DeckSorter.App.Services
{
    public class DecksService : IDecksService
    {
        public DecksService()
        {
            Decks = new List<Deck>
            {
                new Deck()
                {
                    Id = 1,
                    Name = "deck1"
                }
            };
        }

        public List<Deck> Decks { get; private set; }

        public Deck GetDeckByName(string deckName)
        {
            return new Deck
            {
                Name = deckName
            };
        }
    }
}
