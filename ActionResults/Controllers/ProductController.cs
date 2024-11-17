using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ActionResults.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index(int id)
        {
            if(id == 1)
                return Json(new {name = "rahim", age = 3, email = "rahim@gmail.com"});
            if(id == 2)
                return Redirect("details");
            if(id == 3)
                return File("~/files/sample.pdf", "application/pdf");
            if(id == 4)
                return RedirectToAction("Privacy", "Home");
            if(id == 5)
                return Content("I love Riti");
            if(id == 6)
                return BadRequest();
            if(id == 7)
                return NotFound();
            if(id == 8)
                return NoContent();
            if(id == 9)
                return Unauthorized();
            return Ok();
            // return View(); 
        }
        [Route("details")]
        public ViewResult Details()

        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}