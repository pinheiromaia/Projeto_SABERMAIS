using System.Security.AccessControl;

namespace Projeto_SABERMAIS.Models
{
    public class Resposta
    {
        public int Id { get; set; }

        public string Conteudo { get; set; }

        public string Autor { get; set; }

        public DateTime DataCriacao { get; set; }

        // Relacionamento
        public int AulaId { get; set; }
        public Pergunta pergunta { get; set; }

        public List<Resposta> Respostas { get; set; } = new List<Resposta>();
    }
}

