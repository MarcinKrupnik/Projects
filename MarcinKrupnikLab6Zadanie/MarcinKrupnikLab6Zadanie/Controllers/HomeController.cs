using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MarcinKrupnikLab6Zadanie.Models;
using System.IO;

namespace MarcinKrupnikLab6Zadanie.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Lista domów do wyświetlania
        /// </summary>
        List<HouseModel> allHouses;


        public HomeController()
        {
            this.allHouses = new List<HouseModel>();
            allHouses.Add(new HouseModel("Studio", 12, 1, 72000,  "Warsaw", "~/studio.jpg"));
            allHouses.Add(new HouseModel("Flat", 70 , 3, 250000, "Cracow", "~/flat.jpg"));
            allHouses.Add(new HouseModel("House", 140, 8, 382000, "Radom", "~/house.jpg"));
            allHouses.Add(new HouseModel("Residence", 300, 15, 890000, "Namysłów", "~/residence.jpg"));
            
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAllHouses()
        {
            return View(this.allHouses);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetListOfTypes()
        {
            // Lista nazw modeli samochodów do wyświetlenia
            List<string> allTypes = new List<string>();

            // Pętla dodająca model samochodu do listy
            foreach (HouseModel house in this.allHouses)
            {
                allTypes.Add(house.Type);
            }
            // Przekazanie listy modeli do widoku
            return View(allTypes);
        }
        [HttpGet]
        public IActionResult GetHouseByType(string type)
        {
            // Wyszukanie samochodu po modelu
            HouseModel house = this.allHouses.Where(a => a.Type.ToLower() == type.ToLower()).FirstOrDefault();
            // Przekazanie obiektu do widoku
            return View(house);
        }
        
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlenie powitania po wypełnieniu formularza kontaktowego
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactModel userData)
        {
            string allInfo = userData.FirstName + " " + userData.LastName + " " + userData.Choose + " " + userData.Mail;
           
            using (StreamWriter sw = new StreamWriter(@"Save.txt"))
            {

                sw.WriteLine(allInfo);

            }

            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
        }
        [HttpGet]
        public IActionResult DeveloperForm()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlenie powitania po wypełnieniu formularza developerskiego
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeveloperForm(DeveloperModel companyData)
        {
            string allInfo = companyData.CompanyName + " " + companyData.CompanyNumber + " " + companyData.CompanyMail;
          
            using (StreamWriter sw = new StreamWriter(@"SaveDeveloper.txt"))
            {

                sw.WriteLine(allInfo);

            }

            string fullName = companyData.CompanyName;
            ViewBag.CompanyName = fullName;
            return View("DeveloperFormGreetings");
            
        }
        [HttpGet]
        public IActionResult WriteOpinion()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlenie powitania po wypełnieniu formularza developerskiego
        /// </summary>
        /// <param name="opinionData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult WriteOpinion(OpinionModel opinionData)
        {
            string allInfo = opinionData.Opinion;

            using (StreamWriter sw = new StreamWriter(@"SaveOpinion.txt"))
            {

                sw.WriteLine(allInfo);

            }

            string opinion = opinionData.Opinion;
            TempData["opinionT"] = opinion;

            return View("Index");

        }
        public IActionResult ShowOpinion()
        {
            ViewBag.opinionT = TempData["opinionT"];
            
            return View("ShowOpinion");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
