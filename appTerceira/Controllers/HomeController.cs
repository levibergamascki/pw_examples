using appTerceira.Models;
using System.Web.Mvc;

namespace appTerceira.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 12;
            pessoa.Nome = "Lau";
            pessoa.Sexo = 'M';

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}