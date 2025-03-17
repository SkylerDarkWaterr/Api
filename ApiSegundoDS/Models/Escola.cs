namespace ApiSegundoDS.Models
{
    public class Escola
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CNPJ { get; set; }
        public Aluno? Aluno { get; set; }
        public Professor? Professor { get; set; }
    }
}