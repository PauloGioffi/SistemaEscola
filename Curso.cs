namespace SistemaEscola
{
    internal class Curso
    {
        public string Nome { get; private set; }
        public int ID { get; private set; }
        public List<Aluno> Alunos { get; set;}
        public List<Disciplina> DisciplinasCurso { get; private set;}

        public Curso (string nome, int iD)
        {
            Nome = nome;
            ID = iD;
            this.Alunos = new();
            this.DisciplinasCurso = new();
        }
        public void AdicionarAlunoCurso(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        public void ListarAlunosCurso()
        {
            Console.WriteLine($"Segue a lista de alunos do curso de {Nome}: ");
            Console.WriteLine("");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("");
        }
        public void AdicionarDisciplinaCurso(Disciplina disciplina) 
        { 
            DisciplinasCurso.Add(disciplina);
            
        }
        public void ListarDisciplinaCurso() 
        {
            Console.WriteLine($"Segue a lista de disciplinas do curso de {Nome}: ");
            Console.WriteLine("");
            foreach (var disciplina in DisciplinasCurso)
            {
                Console.WriteLine(disciplina.Titulo);
            }
            Console.WriteLine("");
        }
    }
}
