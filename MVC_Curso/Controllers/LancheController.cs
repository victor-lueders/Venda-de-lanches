using Microsoft.AspNetCore.Mvc;
using MVC_Curso.Repositories.Interfaces;
using MVC_Curso.ViewModels;

namespace MVC_Curso.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);

            var lanches = new LancheListViewModel();
            lanches.Lanches = _lancheRepository.Lanches;
            lanches.CategoriaAtual = "Categoria";

            return View(lanches);
        }
    }
}
