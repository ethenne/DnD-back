using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDBackend.Services;
using DnDBackend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DnDBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly CharactersService _characterService;

        public CharacterController(CharactersService charactersService)
        {
            _characterService = charactersService;
        }

        [HttpGet]
        public ActionResult<List<Character>> Get() =>
                    _characterService.Get();

        [HttpGet("{id:length(24)}", Name = "GetCharacter")]
        public ActionResult<Character> Get(string id)
        {
            var character = _characterService.Get(id);

            if (character == null)
            {
                return NotFound();
            }

            return character;
        }

        [HttpPost]
        public ActionResult<Character> Create(Character character)
        {
            _characterService.Create(character);

            return CreatedAtRoute("GetCharacter", new { id = character.Id.ToString() }, character);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Character characterIn)
        {
            var character = _characterService.Get(id);

            if (character == null)
            {
                return NotFound();
            }

            _characterService.Update(id, characterIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var character = _characterService.Get(id);

            if (character == null)
            {
                return NotFound();
            }

            _characterService.Remove(character.Id);

            return NoContent();
        }
    }
}
