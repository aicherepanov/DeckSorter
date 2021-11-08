using DeckSorter.Domain.Models;
using DeckSorter.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DeckSorter.DataAccess
{
    public class DecksRepository : IDecksRepository
    {
        private readonly DecksContext _context;

        public DecksRepository(DecksContext context)
        {
            _context = context;
        }

        public void Create(Deck deck)
        {
            var newDeck = new Entities.Deck
            {                
                DeckName = deck.DeckName
            };
            foreach (Card card in deck.Cards)
            {
                newDeck.Cards.Add(new Entities.Card() { Suit = card.Suit, Rank = card.Rank, Index = card.Index });
            }
            _context.Decks.Add(newDeck);
            _context.Cards.AddRange(newDeck.Cards);
            _context.SaveChanges();
        }

        public void Delete(Deck deck)
        {
            var deckToRemove = new Entities.Deck
            {               
                DeckName = deck.DeckName,
                DeckID = deck.DeckId
            };
            foreach (Card card in deck.Cards)
            {
                deckToRemove.Cards.Add(new Entities.Card() { CardID = card.CardId, Suit = card.Suit, Rank = card.Rank, Index = card.Index });
            }
            _context.Cards.RemoveRange(deckToRemove.Cards);
            _context.Decks.Remove(deckToRemove);                      
            _context.SaveChanges();
        }

        public Deck Get(string name)
        {
            var deck = _context.Decks.FirstOrDefault(x => x.DeckName == name);
            _context.Entry(deck).Collection(x => x.Cards).Load();

            var cards = deck.Cards;
            
            var domainDeck = new Deck
            {
                DeckId = deck.DeckID,
                DeckName = deck.DeckName
            };
            foreach (Entities.Card card in cards)
            {
                domainDeck.Cards.Add(new Card() { DeckId = deck.DeckID, CardId = card.CardID, Suit = card.Suit, Rank = card.Rank, Index = card.Index });
            }

            return domainDeck;
        }

        public IEnumerable<Deck> GetDecksList()
        {
            throw new System.NotImplementedException();
        }

        public void Shuffle(Deck deck)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Deck deck)
        {
            throw new System.NotImplementedException();
        }
    }
}
