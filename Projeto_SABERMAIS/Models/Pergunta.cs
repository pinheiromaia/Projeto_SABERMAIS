using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Transactions;

namespace Projeto_SABERMAIS.Models
{
    [Table("Perguntas")]
    public class Pergunta
    {
        [Key]
        public int Id { get; set; }

        public string Conteudo { get; set; }

        public string Autor { get; set; }

        public DateTime DataCriacao { get; set; }

        //Relacionamento

        public int AulaId { get; set; }

        public Aula aula { get; set; }

        public List<Resposta> Respostas { get; set; } = new List<Resposta>();
    }
}