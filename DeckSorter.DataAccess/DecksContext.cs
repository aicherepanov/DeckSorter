using DeckSorter.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace DeckSorter.DataAccess
{
    public class DecksContext : DbContext
    {
        public DecksContext([NotNullAttribute] DbContextOptions<DecksContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Deck> Decks { get; set; }
    }
}
