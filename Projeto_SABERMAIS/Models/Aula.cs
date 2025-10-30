namespace Projeto_SABERMAIS.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string VideoUrl { get; set; }

        // Uma aula pode ter várias perguntas
        public List<Pergunta> Perguntas { get; set; } = new List<Pergunta>();
    }
}
   