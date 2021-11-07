using DeckSorter.Api.ResourceModels;
using DeckSorter.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeckSorter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecksController : Controller
    {
        private readonly IDecksService _decksService;

        public DecksController(IDecksService deckService)
        {
            _decksService = deckService;
        }

        [HttpGet]
        public ActionResult<bool> GetDeckByName(GetDeckRequest request)
        {         
            return Ok(_decksService.GetDeckByName(request.Name).Name);
        }
    }
}
