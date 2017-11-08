using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReeTail.Models;

namespace ReeTail.Controllers
{
    public class ItemSearchController : Controller
    {
        // GET: ItemSearch/Random
        public ActionResult Random()
        {
            var ItemName = new ItemSearch() { SearchItemName = "Car" };

            return View();
        }
    }
}