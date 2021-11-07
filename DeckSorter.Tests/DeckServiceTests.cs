using DeckSorter.App.Services;
using NUnit.Framework;

namespace DeckSorter.Tests
{
    class DeckServiceTests
    {       
        [TestCase("Test")]
        public void GetDeckByName_ShouldReturnDeck(string deckName)
        {
            // arrange
            var service = new DecksService();

            // act
            var result = service.GetDeckByName(deckName);

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(deckName, result.Name);

            Assert.IsNotNull(result.Cards);          
        }
    }
}
