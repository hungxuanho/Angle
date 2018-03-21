using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angle.Controllers
{
    public class FormsController : Controller
    {

        
        //public IActionResult FormLogin()
        public IActionResult FormLogin(IFormCollection formCollection)
        {

            //ViewData["adresse"] = "Adresse 1";
            //
            //Angle.Models.Kunde k = new Models.Kunde();
            //k.navn = "Hung Xuan Ho";
            //k.passord = "test_hung_pw";
            //ViewData["kunde"] = k;
            //
            //List<Models.Kunde> kList = new List<Models.Kunde>();
            //for (int i = 0; i <= 3; i++)
            //{
            //    Models.Kunde _k = new Models.Kunde();
            //    _k.navn = String.Format("Navn{0}", i);
            //    _k.passord = String.Format("pw{0}", i);
            //    kList.Add(_k);
            //}
            ////ViewData["kundeListe"] = kList;


            //string ViewName = "FormLogin";
            //return View(ViewName, kList);s
            //return View();

            if (Request.HttpContext.Request.Method == "POST")
            {
                string validatedEmail = "a";
                string validatedPw = "a";

                string email = formCollection["email"];
                string pw = formCollection["password"];

                if (email != validatedEmail || pw != validatedPw)
                {
                    ViewData["email"] = email;
                    ViewData["pw"] = pw;
                    TempData["error"] = "Epost og/eller passord feil."; // En måte å overføre state til View
                    ViewBag.Error = "Epost og/eller passord feil.";
                    return View();
                }

                //string ViewName = "FormLogin";
                //return View(ViewName, kList);
                //return View(kList);  // Dette returnerer View med samme navn som navnet til denne action method, nemlig ValidateStyretUSer
                //return View("LoginRiktig");  // Same view and controller is ok
                //return View("~/Views/Dashboard/StyretDashboard_h.cshtml");  // view of another controller is not ok
                //return View("~/Views/Selskaper_Roller/Selskaper_Roller.cshtml");
                return Redirect("~/Selskap/Index");
            }
            else
            {
                return View();
            }
           
            
        }


        
        public IActionResult Validate(IFormCollection formCollection)
        {
            string validatedEmail = "a";
            string validatedPw = "a";

            string email = formCollection["email"];
            string pw = formCollection["password"];

            if (email != validatedEmail || pw != validatedPw)
            {
                ViewData["email"] = email;
                ViewData["pw"] = pw;
                TempData["error"] = "Epost og/eller passord feil."; // En måte å overføre state til View
                ViewBag.Error = "Epost og/eller passord feil.";
                return View("FormLogin");
            }

            //string ViewName = "FormLogin";
            //return View(ViewName, kList);
            //return View(kList);  // Dette returnerer View med samme navn som navnet til denne action method, nemlig ValidateStyretUSer
            //return View("LoginRiktig");  // Same view and controller is ok
            //return View("~/Views/Dashboard/StyretDashboard_h.cshtml");  // view of another controller is not ok
            return View("~/Views/Selskaper_Roller/Selskaper_Roller.cshtml");
        }


        public IActionResult FormExtended()
        {
            return View();
        }

        public IActionResult FormStandard()
        {
            return View();
        }

        public IActionResult FormValidation()
        {
            return View();
        }

        public IActionResult FormUpload()
        {
            return View();
        }
        
        public IActionResult FormWizard()
        {
            return View();
        }

        public IActionResult FormXEditable()
        {
            return View();
        }

        // Used for xEditable demo to receive post confirmation
        [HttpPost]
        public IActionResult XEditableEdit()
        {
            return Content("");
        }

        public IActionResult FormImgCrop()
        {
            return View();
        }
    }
}