﻿namespace ApiSegundoDS.Models
{
    public class Escola
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CNPJ { get; set; }
        public int AlunoID { get; set; }
        public int ProfessorID { get; set; }
    }
}