using DeckSorter.Api.ResourceModels;
using DeckSorter.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

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
        public ActionResult<bool> GetDeck(GetDeckRequest request)
        {
            return Ok(_decksService.Get(request.Name));
        }

        [HttpPost]
        public ActionResult<bool> CreateDeck(CreateDeckRequest request)
        {
            try
            {
                bool isValid = String.IsNullOrEmpty(request.Name) != true;
                if (isValid)
                {
                    var result = _decksService.Create(request.Name);
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public ActionResult<string> DeleteDeck(DeleteDeckRequest request)
        {
            try
            {
                bool isValid = String.IsNullOrEmpty(request.Name) != true;
                if (isValid)
                {
                    _decksService.Delete(request.Name);
                    return Ok("deck deleted");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
