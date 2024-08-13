using Microsoft.AspNetCore.Mvc;

namespace CRUD_NP_PracticeCMS.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
