using Microsoft.AspNetCore.Mvc;
using PatientPortal.Models;

namespace PatientPortal.Controllers
{
    public class LabTestsController : Controller
    {
        // GET: LabTestsController
        public ActionResult LabTests()
        {
            var labtests = new LabTests (){
                LabTestId = 1001, LabTestname = "A1C", TestDate = "May 9, 2025", LabResults = "Pass"
            };
            return View(labtests);
        }

    }
}
