using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckSorter.Api.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();    
    }
}
