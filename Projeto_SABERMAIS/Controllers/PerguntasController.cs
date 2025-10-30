using Microsoft.AspNetCore.Mvc;
using Projeto_SABERMAIS.Models;
using System;

namespace Projeto_SABERMAIS.Controllers
{

    public class PerguntasController : Controller
    {
        private readonly AppDbcotext _context;

        public PerguntasController(AppDbcotext context)
               {
            _context = context;
        }

        // Exibe perguntas da aula
        public IActionResult Aula(int aulaId)
        {
            var perguntas = _context.Perguntas
                .Where(p => p.AulaId == aulaId)
                .OrderByDescending(p => p.DataCriacao)
                .ToList();

            ViewBag.AulaId = aulaId;
            return View(perguntas);
        }

        // Enviar nova pergunta
        [HttpPost]
        public IActionResult CriarPergunta(int aulaId, string conteudo, string autor)
        {
            var pergunta = new Pergunta
            {
                Conteudo = conteudo,
                Autor = autor,
                AulaId = aulaId,
                DataCriacao = DateTime.Now
            };

            _context.Perguntas.Add(pergunta);
            _context.SaveChanges();

            return RedirectToAction("Aula", new { aulaId });
        }

        // Enviar resposta
        [HttpPost]
        public IActionResult CriarResposta(int perguntaId, string conteudo, string autor)
        {
            var resposta = new Resposta
            {
                Conteudo = conteudo,
                Autor = autor,
                pergutaId = perguntaId,
                DataCriacao = DateTime.Now
            };

            _context.Respostas.Add(resposta);
            _context.SaveChanges();

            var pergunta = _context.Perguntas.FirstOrDefault(p => p.Id == perguntaId);
            return RedirectToAction("Aula", new { aulaId = pergunta.AulaId });
        }
    }
}
