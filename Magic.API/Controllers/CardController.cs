using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Service;
using Magic.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Magic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private CardService _cardService;

        public CardController()
        {
            _cardService = new CardService();
        }

        // GET: api/Card
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var result = _cardService.GetCards();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // GET: api/Card/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            try
            {
                var result = _cardService.GetCards(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // POST: api/Card
        [HttpPost]
        public ActionResult Post(Card card)
        {
            try
            {
                _cardService.CreateCard(card);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // PUT: api/Card/
        [HttpPut()]
        public ActionResult Put(Card card)
        {
            try
            {
                _cardService.UpdateCard(card);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{cardId}")]
        public ActionResult Delete(int cardId)
        {
            try
            {
                _cardService.RemoveCard(cardId);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
    }
}
