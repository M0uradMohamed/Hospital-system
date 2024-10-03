using Hospital.data;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class DoctorsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult bookAppointment()
        {
            var result = context.Doctors.ToList();
            return View(result);
        }
        public IActionResult completeAppointment(string DrName)
        {
            var result = context.Doctors.Where(d=> d.Name == DrName).ToList();
            return View(result);
        }
    }
}
