using Microsoft.AspNetCore.Mvc;
using RegistroCarrosdosAlunosIF.Actions;
using RegistroCarrosdosAlunosIF.Models;
using System.Diagnostics;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RegistroCarrosdosAlunosIF.Controllers
{
    public class Alunos : Controller
    {
        private readonly ICadastrosRepositorio _cadastrosRepositorio;
        public Alunos(ICadastrosRepositorio cadastrosRepositorio)
        {
            _cadastrosRepositorio = cadastrosRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }       
        public IActionResult Home (string prontuario)
        {
            try
            {
                Models.Cadastros cadastros = _cadastrosRepositorio.BuscarDados(prontuario);

                if (cadastros != null)
                {
                    
                    return View("Home", cadastros);
                }
                else
                {
                    
                    TempData["MensagemErro"] = "Opa! Não foi possível encontrar os dados do cadastro.";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception erro)
            {
              
                Console.WriteLine($"Erro ao buscar dados: {erro.Message}");

                TempData["MensagemErro"] = "Opa! Algo deu errado ao buscar os dados do cadastro.";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Criar()
        {
            return View();
        }
      
        public IActionResult Busca(string prontuario)
        {
            try
            {
                Models.Cadastros cadastros = _cadastrosRepositorio.BuscarDados(prontuario);           
                return View(cadastros);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Opa! Não foi possível encontrar seu cadastro! Revise os dados e tente novamente: {erro.Message}";
                return RedirectToAction("Busca");
            }

        }

        [HttpPost]
        public IActionResult Criar(Models.Cadastros cadastros)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(cadastros);
                }
                _cadastrosRepositorio.Adicionar(cadastros);
                TempData["MensagemSucesso"] = "Cadastrado realizado com sucesso!";
                return RedirectToAction("Home", new { prontuario = cadastros.Prontuário });
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Opa! Nao foi possivel realizar seu cadastro! Revise os dados e tente novamente!:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Sobre()
        {
            return View();
        }

    }
}
