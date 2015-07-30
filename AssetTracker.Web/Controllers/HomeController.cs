using System.Web.Mvc;
using AssetTracker.Web.Service;

namespace AssetTracker.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public HomeController()
        {
            _employeeService = new EmployeeService();
        }

        public ActionResult Index()
        {
            var employee = _employeeService.Find(1);
            return View(employee);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}