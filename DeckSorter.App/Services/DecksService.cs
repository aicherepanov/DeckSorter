using DeckSorter.Domain.Models;
using DeckSorter.Domain.Repositories;
using DeckSorter.Domain.Services;
using System;
using System.Collections.Generic;

namespace DeckSorter.App.Services
{
    public class DecksService : IDecksService
    {
        private readonly IDecksRepository _decksRepository;

        public DecksService(IDecksRepository decksRepository)
        {
            _decksRepository = decksRepository;
            Decks = new List<Deck>();
        }

        public List<Deck> Decks { get; private set; }

        public bool Create(string name)
        {            
            var newDeck = new Deck()
            {
                DeckName = name,
                Cards = GetSortedCardList()
            };
            try
            {
                _decksRepository.Create(newDeck);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void DeleteDeck(Deck deck)
        {
            throw new System.NotImplementedException();
        }

        public Deck GetDeck(string deckName)
        {
            var result = _decksRepository.Get(deckName);

            if (result == null || result.Cards.Count == 0)
            {
                return new Deck
                {
                    DeckName = deckName
                };
            }
            return new Deck
            {
                DeckName = deckName
            };
        }

        public void ShuffleDeck(Deck deck)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDeck(Deck deck)
        {
            throw new System.NotImplementedException();
        }

        private List<Card> GetSortedCardList()
        {
            var cards = new List<Card>();
            IEnumerable<Ranks> ranks = (Ranks[])Enum.GetValues(typeof(Ranks));
            IEnumerable<Suits> suits = (Suits[])Enum.GetValues(typeof(Suits));
            int index = 0;
            foreach (Ranks rank in ranks)
            {
                foreach (Suits suit in suits)
                {
                    cards.Add(new Card() { Suit = suit, Rank = rank, Index = index });
                    index++;
                }                
            }
            return cards;
        }
    }
}
