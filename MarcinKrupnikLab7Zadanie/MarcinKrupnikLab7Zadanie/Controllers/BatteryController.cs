using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcinKrupnikLab7Zadanie.Models;
using MarcinKrupnikLab7Zadanie.Services;
using MarcinKrupnikLab7Zadanie.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarcinKrupnikLab7Zadanie.Controllers
{
    [Route("api/battery")]
    [ApiController]
    public class BatteryController : ControllerBase
    {
        private IBatteryService batteryService;
        private readonly IApplicationDbGeneric<Battery> _batteries;
        /// <summary>
        /// Konstruktor bezparametryczny
        /// snippet - ctor + tab tab
        /// </summary>
        public BatteryController(IBatteryService _batteryService)
        {
            _batteries = new ApplicationDbGeneric<Battery>();
            batteryService = _batteryService;
        }

        /// <summary>
        /// Metoda get pobierająca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var batteries = batteryService.Get();
            return Ok(batteries);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Battery battery)
        {
            var id = batteryService.Post(battery);
            _batteries.Create(battery);
            _batteries.Save();
            return Ok(id);
        }

        /// <summary>
        /// Metoda aktualizująca wyświetlacz o wybranym Id
        /// </summary>
        /// <param name="battery"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Battery battery, [FromRoute] int id)
        {
            var isUpdateSuccessful = batteryService.Put(battery, id);
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
            bool isDeleteSuccesful = batteryService.Delete(id);
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
