using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CachingTutorial.Controllers
{
    public class CachingController : Controller
    {
        // GET: Caching : Cambiar Modo de Visualización

        //[OutputCache(Duration = 20, VaryByParam ="mode")]
        //[OutputCache(CacheProfile = "NoParam20Secs")]
        public ActionResult ChangeMode(bool? mode, int? dark, int? clear)
        {

            if (mode != null)
            {
                bool? ScreenMode = mode;

                if (ScreenMode == true)
                {
                    ViewBag.Mode = true;

                    dark++;
                    ViewBag.DarkCalls = dark;
                    ViewBag.ClearCalls = clear;
                }
                else if (ScreenMode == false)
                {
                    ViewBag.Mode = false;

                    clear++;
                    ViewBag.ClearCalls = clear;
                    ViewBag.DarkCalls = dark;
                }

            }
            else if (mode == null)
            {

                ViewBag.Mode = false;
                ViewBag.DarkCalls = 0;
                ViewBag.ClearCalls = 0;

            }
            ViewBag.Fecha = DateTime.Now.ToLongDateString().ToUpper();
            ViewBag.Hora = DateTime.Now.ToLongTimeString();
            return View();
        }
    }
}

