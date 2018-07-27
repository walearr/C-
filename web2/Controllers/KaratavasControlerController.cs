using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web2.Controllers
{
    public class KaratavasControlerController : Controller
    {
        public List<string> Vardi = new List<string>()
        {
            "VILCIENS",
            "HES",
            "CITRONS",
        };

        public static string MinamaisVards;

        public static char[] AtminetaisVards;

        public static int Dzivibas;


        // GET: /<controller>/
        public IActionResult Index(bool? burtsIrAtrasts = null)
        {
            //1.3 Aizpilda masivu AtviminetaisvARDS AR "-"

            // 1. ja minamais vardsVards nav definets, tad 
            if (string.IsNullOrEmpty(MinamaisVards))
            {
                Dzivibas = 5;
                
                //1.1 Nejausi izvelas vardu no saraksta vardi
                int RNG = new Random().Next(Vardi.Count);
                //1.2 Aizpilda maingo Minamaisvards
                MinamaisVards = Vardi[RNG];
                //otrs variants:
                //Vardi = Vardi.OrderBy(Vardi => Guid.NewGuid()).ToList();
                //MinamaisVards = Vardi[0];


                AtminetaisVards = new char[MinamaisVards.Length];
                for (int i = 0; i < MinamaisVards.Length; i++)
                {
                    AtminetaisVards[i] = '_';
                }
            }


            ViewBag.AtminetaisVards = String.Join(" ", AtminetaisVards);
            if(burtsIrAtrasts.HasValue)
            {
                if (burtsIrAtrasts.Value == false)
                {

                    ViewBag.Pazinojums = "Burts nav saja varda";
                    Dzivibas--;
                }

            }
            if(MinamaisVards == new string(AtminetaisVards))
            {
                ViewBag.pazinojums = "Vards ir atminets!";

            }
            if(Dzivibas <= 0)
            {
                ViewBag.Pazinojums = "Bigusas dzivibas!";
            }
            ViewBag.IrDzivibas = Dzivibas > 0;
            ViewBag.DzivibuSkaits = Dzivibas;




            return View();
        }
        public IActionResult Minet(string vards)
        {
            //1. Jaaizvieto AtminetaisVards "_" ar burtu
            //  ja burts ir varda MinamaisVards
            MinamaisVards = MinamaisVards.ToUpper();
            vards = vards.ToUpper();
            char burts = vards[0];
            bool irAtrasts = false;
           
            for (int i = 0; i < MinamaisVards.Length; i++)
            {
                if(burts == MinamaisVards[i])
                {
                    AtminetaisVards[i] = burts;
                    irAtrasts = true;

                }

            }
            return RedirectToAction("Index", new { burtsIrAtrasts = irAtrasts });

        }
        public IActionResult JaunaSpele()
        {
            MinamaisVards = null;
            return RedirectToAction("Index");
        }
        
        
    }
} 