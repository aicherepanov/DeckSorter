using DeckSorter.Domain.Models;
using DeckSorter.Domain.Repositories;
using DeckSorter.Domain.Services;
using System.Collections.Generic;

namespace DeckSorter.App.Services
{
    public class DecksService : IDecksService
    {
        private readonly IDecksRepository _decksRepository;

        public DecksService(IDecksRepository decksRepository)
        {
            _decksRepository = decksRepository;
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

        public Deck GetDeck(string deckName)
        {
            var result = _decksRepository.GetDeck(deckName);

            return new Deck
            {
                Name = deckName
            };
        }
    }
}
