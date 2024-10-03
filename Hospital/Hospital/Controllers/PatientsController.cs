using Hospital.data;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class PatientsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult dispalyPatients()
        {
            var result = context.Patients.OrderBy(p=>p.Date).ToList();
            return View(result);
        }
        public IActionResult savePatient(Patient patient )
        {
            context.Patients.Add( patient );
           context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
