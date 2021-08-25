using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Professor
    {
        public Professor(){}
        public Professor(int ID, string Nome)
        {
            this.ID = ID;
            this.Nome = Nome;
        }

        public int ID {get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string telefone { get; set; }
        IEnumerable<Disciplina>Disciplina{get; set;}
    }
}