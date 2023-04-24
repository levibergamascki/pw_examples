using appTerceira.Models;
using System.Web.Mvc;

namespace appTerceira.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Fisica pj = new Fisica
            {
                Id = 2,
                Nome = "Roberta",
                Sexo = 'F',
                CPF = 12345678911,
                RG = 12345678,
                Dig_RG = '9'
            };


            ViewData["Id"] = pj.Id;
            ViewData["Nome"] = pj.Nome;
            ViewData["Sexo"] = pj.Sexo;
            ViewData["CPF"] = pj.CPF;
            ViewData["RG"] = pj.RG;
            ViewData["Dig_RG"] = pj.Dig_RG;

            return View(pj);
        }

        public ActionResult About()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 12;
            pessoa.Nome = "Lau";
            pessoa.Sexo = 'M';

            return View(pessoa);
        }

        public ActionResult Contact()
        {
            Juridica pj = new Juridica();

            pj.Id = 1001;
            pj.Nome = "Fábrica de Gênios";
            pj.Cnpj = 12345789123412;
            pj.IE = 123456789;  

            return View(pj);
        }

        public ActionResult ExemploTempData()
        {
            Juridica pj = new Juridica();

            pj.Id = 256;
            pj.Nome = "Desenvolvedores e CIA";
            pj.Cnpj = 12345678988888;
            pj.IE = 123499999;

            TempData["Id"] = pj.Id;
            TempData["Nome"] = pj.Nome;
            TempData["Cnpj"] = pj.Cnpj;
            TempData["IE"] = pj.IE;

            return RedirectToAction("Contact");
        }

    }
}