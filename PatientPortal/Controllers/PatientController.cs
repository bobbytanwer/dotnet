using Microsoft.AspNetCore.Mvc;
using PatientPortal.Models;

namespace PatientPortal.Controllers
{
    public class PatientController : Controller
    {
        // GET: PatientController
        public ActionResult Patient()
        {

            var patient = new Patient (){ FirstName = "dhipender ", LastName = "tanwer" };
            return View(patient);
        }

    }
}
