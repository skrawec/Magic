using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magic.Domain;
using Magic.Domain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Magic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private PersonService _personService; 

        public PersonController()
        {
            _personService = new PersonService();
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            try
            {
                var result = _personService.GetPerson(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        [HttpPut("{personId}/{cardId}")]
        public ActionResult AddCard(int personId, int cardId)
        {
            try
            {
                _personService.AddCardToPerson(personId, cardId);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // POST: api/Person
        [HttpPost]
        public ActionResult Post(Person person)
        {
            try
            {
                _personService.AddPerson(person);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // PUT: api/Person/
        [HttpPut]
        public ActionResult Put(Person person)
        {
            try
            {
                _personService.UpdatePerson(person);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{personId}")]
        public ActionResult Delete(int personId)
        {
            try
            {
                _personService.RemovePerson(personId);

                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
    }
}
