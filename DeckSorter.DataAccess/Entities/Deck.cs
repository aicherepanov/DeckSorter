using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeckSorter.DataAccess.Entities
{
    public class Deck
    {
        [Key]
        public int DeckID { get; set; }
        public string DeckName { get; set; }
        public ICollection<Card> Cards { get; set; }
        public Deck()
        {
            Cards = new List<Card>();
        }
    }
}
