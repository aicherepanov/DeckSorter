using DeckSorter.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeckSorter.DataAccess.Entities
{
    public class Card
    {
        [Key]
        public int CardID { get; set; }
        public Suits Suit { get; set; }
        public Ranks Rank { get; set; }
        public int Index { get; set; }
    }
}
