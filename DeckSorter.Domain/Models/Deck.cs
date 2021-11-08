using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeckSorter.Domain.Models
{
    public class Deck
    {
        public int DeckId { get; set; }
        [Required, StringLength(255, MinimumLength = 1)]
        public string DeckName { get; set; }
        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }
}
