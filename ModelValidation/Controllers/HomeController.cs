using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidation.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index() => View("MakeBooking", new Appointment { Date = DateTime.Now });

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt) => View("Completed", appt);
    }
}
