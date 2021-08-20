namespace SmartSchool.WebAPI.Models
{
    public class AlunoDisciplina
    {   
        public AlunoDisciplina(){}
        public AlunoDisciplina(int alunoID, int disciplinaID, Aluno aluno, Disciplina disciplina)
        {
            AlunoID = alunoID;
            DisciplinaID = disciplinaID;
            Aluno = aluno;
            Disciplina = disciplina;
        }

        public int AlunoID { get; set; }
        public int DisciplinaID { get; set; }
        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }

    }
}