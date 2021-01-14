using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvc1DemoControllers.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Mvc1DemoControllers.ViewModels;


// HÄNDELSESTYRDA - > Windows Forms = framework/abstraktion
//WIndows button1_OnClick -> spara i databas
// textBox1_OnChange



// HÄNDELSESTYRDA - > MVC = framework/abstraktion


namespace Mvc1DemoControllers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        

        public IActionResult Index() // Motsvara button1_OnClick
        {
            var a = GetUser();
            return View();
        }


        //Home/Privacy

        //RESPONSIBILITY 
        // Syfte = entry point
        //Hämta data (från db) utifrån aktuell context
        //                      - sida, användare, matat in
        //          /bank/myaccounts
        // Knådar den datan, skapar en viewmodell  samt SKICKA DEN TILL VYN
        // 
        // Vyn -> så enkel, en UI-expert kan förstå -> renderar HTML från viewmodell

        //DVS DET ENDA en controller ska returnera är  Pure html
         
        //public IActionResult MyAccounts() // Motsvara button1_OnClick
        //{
        //    var a = GetUser();
        //    context.Accounts.Where(r => r.UserId == a);
        //    //if (a == "Lisa")
        //    /*
        //     /
        //     */
        //    return View();
        //}

        //public IActionResult ShowAccount(string accountNo) // Motsvara button1_OnClick
        //{
        //    context.Accounts.Where(r => r.AccountNo = accountNo);
        //    //if (a == "Lisa")
        //    /*
        //     /
        //     */
        //    return View();
        //}




        public IActionResult Privacy() // Motsvara button1_OnClick
        {
            /*
             /
             */
            return View();
        }


        // Syfte = entry point
        //Hämta data (från db) utifrån aktuell context
        //                      - sida, användare, matat in
        //          /bank/myaccounts
        // Knådar den datan, skapar en viewmodell  samt SKICKA DEN TILL VYN
        // 
        // Vyn -> så enkel, en UI-expert kan förstå -> renderar HTML från viewmodell

        //DVS DET ENDA en controller ska returnera är  Pure html
        //Home/Hej
        public IActionResult Hej() // Motsvara button1_OnClick
        {

            //ViewData = global dictionary
            //ViewData + ViewBag =  GLOBALA VARIABLER

            //Unik data för Context
            // hämta från db
            var currentUser = "Stefan";
            var list = new List<string> {"Bok 1 bla bla", "Bok 2 hej hopp" };

            //ViewData["userName"] = currentUser;
            //ViewData["listan"] = list;


            var viewModel = new HomeHejViewModel();
            viewModel.Username = currentUser;
            viewModel.Books = list;

            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() // Motsvara button1_OnClick
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        string GetUser()
        {
            return User.Identity.Name;
        }
    }
}
