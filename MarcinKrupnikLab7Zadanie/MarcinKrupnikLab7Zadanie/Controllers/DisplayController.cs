using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcinKrupnikLab7Zadanie.Models;
using MarcinKrupnikLab7Zadanie.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarcinKrupnikLab7Zadanie.Repositories;

namespace MarcinKrupnikLab7Zadanie.Controllers
{
    
    [Route("api/display")]
    [ApiController]
    public class DisplayController : ControllerBase
    {
       
        private readonly IApplicationDbGeneric<Display> _displays;
        private IDisplayService displayService;

        /// <summary>
        /// Konstruktor bezparametryczny
        /// snippet - ctor + tab tab
        /// </summary>
        public DisplayController(IDisplayService _displayService)
        {
            _displays = new ApplicationDbGeneric<Display>();
            displayService = _displayService;
        }

        /// <summary>
        /// Metoda get pobierająca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var displays = displayService.Get();
            return Ok(displays);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Display display)
        {
           
        var id = displayService.Post(display);
            _displays.Create(display);
            _displays.Save();
            return Ok(id);
        }

        /// <summary>
        /// Metoda aktualizująca wyświetlacz o wybranym Id
        /// </summary>
        /// <param name="display"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Display display, [FromRoute] int id)
        {
            var isUpdateSuccessful = displayService.Put(display, id);
            if (isUpdateSuccessful)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Usunięcie wyświetlacza
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            bool isDeleteSuccesful = displayService.Delete(id);
            if (isDeleteSuccesful)
            {
                ;
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
