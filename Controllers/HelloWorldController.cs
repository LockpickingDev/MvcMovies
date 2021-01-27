using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web; //HtmlEncoder
using System.Threading.Tasks;

namespace MvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {

        // GET: /HelloWorld/
        public IActionResult Index()
        {
            //return IActionResult
            return View(); //View name not specified, so Default view called - has same name as method calling it: Index
        }

        /*** Cannot Overload and have multiple endpoints with same name ***/
        //// GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // GET: /HelloWorld/Welcome/ 
        //public string Welcome(string name, int numTimes = 1)
        //public string Welcome(string name, int ID = 1)
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //Data passed to the view
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View(); //return IActionResult.  Calls Default View "Welcome"

            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}"); //HtmlEncoder.Default.Encode to protect the app from malicious input
        }










    }
}
