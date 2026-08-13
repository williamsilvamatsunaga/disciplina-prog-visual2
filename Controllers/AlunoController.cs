using MeuApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuApp.Controllers;

public class AlunoController : Controller
{
    // Ação GET: Exibe o formulário em branco
    public IActionResult Criar()
    {
        return View();
    }

    // Ação POST: Recebe os dados preenchidos
    [HttpPost]
    public IActionResult Criar(Aluno aluno)
    {
        return Content($"Aluno '{aluno.Nome}' com matrícula '{aluno.Matricula}' recebido com sucesso!");
    }
}