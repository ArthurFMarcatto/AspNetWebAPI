using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Disciplina
    {
        public Disciplina(){}

        public Disciplina(int ID, string nome, int professorID)
        {
            this.ID = ID;
            Nome = nome;
            ProfessorID = professorID;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public int ProfessorID { get; set; }
        public Professor Professor { get; set; }

        public IEnumerable<AlunoDisciplina>AlunosDisciplinas{get; set;}

    }
}