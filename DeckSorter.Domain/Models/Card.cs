namespace DeckSorter.Domain.Models
{
    public class Card
    {
        public int Id { get; set; }
        public Suits Suit { get; set; }
        public Ranks Rank { get; set; }
    }
}
