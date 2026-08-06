using MeuApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuApp.Controllers;

public class AlunoController : Controller
{
    // GET
    public IActionResult Index()
    {
        var alunos = new List<Aluno>()
        {
            new Aluno() { Id = 1, Nome = "William", Curso = "ADS", Nota = 10 },
            new Aluno() { Id = 1, Nome = "William", Curso = "ADS", Nota = 10 },
            new Aluno() { Id = 1, Nome = "William", Curso = "ADS", Nota = 10 }
        };
        return View(alunos);
    }
}