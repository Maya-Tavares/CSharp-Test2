using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AvaliacaoLp3.Models;

namespace AvaliacaoLp3.Controllers;

public class LojasController : Controller {
    public static List<LojasViewModel> lojas = new List<LojasViewModel>();

    public IActionResult Index()
    {
        return View(lojas);
    }

    public IActionResult Gerenciamento()
    {
        return View(lojas);
    }

    public IActionResult Detalhe(int id)
    {
        return View(lojas[id-1]);
    }

    public IActionResult Formulario()
    {
        return View();
    }

    public IActionResult Cadastro([FromForm] string piso, [FromForm] string nome, [FromForm] string descricao, [FromForm] string tipo, [FromForm] string email)
    {
        foreach(var loja in lojas)
        {
            if(nome == loja.Nome) 
            {
                ViewData["Mensagem"] = "A loja informada já está cadastrada!";
                return View();
            }
        }

        int id = 1;
        for(int i = 0; i < lojas.Count; i++) {
            id++;
        }
       
        lojas.Add(new LojasViewModel(id, piso, nome, descricao, tipo, email));

        ViewData["Mensagem"] = "A loja foi cadastrada com sucesso!";
        return View();
    }

    public IActionResult Excluir(int id)
    {
        lojas.RemoveAt(id-1);
        return View();
    }
}