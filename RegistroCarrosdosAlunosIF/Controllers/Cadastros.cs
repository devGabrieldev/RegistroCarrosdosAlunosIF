using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RegistroCarrosdosAlunosIF.Actions;
using RegistroCarrosdosAlunosIF.Models;

namespace RegistroCarrosdosAlunosIF.Controllers
{
    
    public class Cadastros : Controller
    {
        private readonly ICadastrosRepositorio _cadastrosRepositorio;
        public Cadastros(ICadastrosRepositorio cadastrosRepositorio)
        {
            _cadastrosRepositorio = cadastrosRepositorio;
        }
        public IActionResult Index()
        {
            List<Models.Cadastros> cadastros = _cadastrosRepositorio.BuscarTodos();
            return View(cadastros);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Models.Cadastros cadastros)
        {
            _cadastrosRepositorio.Adicionar(cadastros);
            return RedirectToAction("Index");
        }
        public IActionResult Editar(Models.Cadastros prontuario)
        {
            Models.Cadastros cadastro = _cadastrosRepositorio.CarregarCadastro(prontuario);
            //System.Diagnostics.Debug.WriteLine($"Dados do cadastro carregados: Prontuário - {cadastro.Prontuário}, Nome - {cadastro.Nome}");
            return View(cadastro);

        }


        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
    }

 
}


