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
        public IActionResult Index()
        {
            return View(); //View name not specified, so Default view called - has same name as method calling it: Index
        }


        // GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        /*** Cannot Overload and have multiple endpoints ***/
        //// GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // GET: /HelloWorld/Welcome/ 
        //public string Welcome(string name, int numTimes = 1)
        public string Welcome(string name, int ID = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}"); //HtmlEncoder.Default.Encode to protect the app from malicious input
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }










    }
}
