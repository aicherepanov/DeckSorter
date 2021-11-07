using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeckSorter.DataAccess.Entities
{
    public class Card
    {
        [Key]
        public int CardID { get; set; }
        public int Suit { get; set; }
        public int Rank { get; set; }
        public int Index { get; set; }
    }
}
