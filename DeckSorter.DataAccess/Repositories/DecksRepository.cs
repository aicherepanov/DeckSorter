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
            throw new System.NotImplementedException();
        }

        public Deck Get(string name)
        {
            var deck = _context.Decks.FirstOrDefault(x => x.DeckName == name);

            return new Deck
            {
                DeckId = deck.DeckID,
                DeckName = deck.DeckName
            };
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
