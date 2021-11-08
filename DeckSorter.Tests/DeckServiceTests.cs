using DeckSorter.App.Services;
using DeckSorter.Domain.Repositories;
using DeckSorter.Domain.Services;
using Moq;
using NUnit.Framework;

namespace DeckSorter.Tests
{
    class DeckServiceTests
    {       
        [TestCase("Test")]
        public void GetDeckByName_ShouldReturnDeck(string deckName)
        {
            // arrange
            var deckRepositoryMock = new Mock<IDecksRepository>();
            var shufflerServiceMock = new Mock<IShufflerService>();
            var service = new DecksService(deckRepositoryMock.Object, shufflerServiceMock.Object);

            // act
            var result = service.Get(deckName);

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(deckName, result.DeckName);

            Assert.IsNotNull(result.Cards);          
        }
    }

}
