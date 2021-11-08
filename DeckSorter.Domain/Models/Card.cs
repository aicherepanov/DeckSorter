using System.ComponentModel.DataAnnotations;

namespace DeckSorter.Domain.Models
{
    public class Card
    {        
        public int CardId { get; set; }
        [Required]
        public Suits Suit { get; set; }
        [Required]
        public Ranks Rank { get; set; }
        [Required]
        public int Index { get; set; }
        public int DeckId { get; set; }
    }
}
