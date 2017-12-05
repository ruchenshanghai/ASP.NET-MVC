using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tutorial.Controllers
{
    public class TestController : Controller
    {
        //// GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: /Test
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Test/Second
        public String Second(int id)
        {
            return "This is the Second action method.... id: " + id;
        }
        
        // GET: /Test/Third
        public String Third(String name, int id)
        {
            return "This is the Third action method.... name: " + name + " id: " + id;
        }
    }
}