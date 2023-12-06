using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RegistroCarrosdosAlunosIF.Actions;
using RegistroCarrosdosAlunosIF.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            try
            {
                if (!ModelState.IsValid)
                {                
                return View(cadastros);
                }
                _cadastrosRepositorio.Adicionar(cadastros);
                TempData["MensagemSucesso"] = "Cadastrado realizado com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Opa! Nao foi possivel realizar o cadastrar! Revise os dados e tente novamente!:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Editar(string prontuario)
        {
            Models.Cadastros cadastros = _cadastrosRepositorio.BuscarDados(prontuario);
            return View(cadastros);
        }

        [HttpPost]
        public IActionResult Alterar(Models.Cadastros cadastros)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (cadastros != null)
                    {
                        _cadastrosRepositorio.Alterar(cadastros);
                        TempData["MensagemSucesso"] = "Contato alterado com sucesso!";
                        return RedirectToAction("Index"); 
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Opa! Não foi possível encontrar o cadastro para atualização.";
                    }
                }
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Opa! Nao foi possivel atualizar o cadastro! Tente novamente, mais detalhes:{erro.Message}";
            }

            return RedirectToAction("Index");
        }

        public IActionResult ApagarConfirmacao(string prontuario)
        {
            Models.Cadastros cadastros = _cadastrosRepositorio.BuscarDados(prontuario);
            return View(cadastros);
        }

        public IActionResult Apagar(string prontuario)
        {
            try
            {              
                _cadastrosRepositorio.Apagar(prontuario);
                TempData["MensagemSucesso"] = "Contato excluido com sucesso!";                
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Opa! Nao foi possivel excluir o cadastro! Tente novamente, mais detalhes:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
        public IActionResult AdminConfirmacao()
        {
            return View();
        }
     
        public IActionResult Confirma(string cd)
        {
            try
            {
                string conf = "0oP46m!nç2@Z3R&A";

                if (cd != conf)
                {
                    TempData["MensagemErro"] = $"Opa! Não foi possível entrar como administrador! Tente novamente";
                    return RedirectToAction("AdminConfirmacao");
                }
                TempData["MensagemSucesso"] = $"Seja bem vindo! Tenha um bom dia de trabalho!";
                return RedirectToAction("Index");  
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Ocorreu um erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}


