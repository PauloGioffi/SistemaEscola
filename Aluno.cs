namespace SistemaEscola
{
    internal class Aluno:Pessoa
    {
        public int Matricula { get; private set; }
        public List<Curso> Cursos { get; set; }

        public Aluno(string nome, int idade, int matricula) : base(nome, idade)
        {
            Matricula = matricula;
            this.Cursos = new();
        }
        public void MatricularAluno(Aluno aluno,Curso curso)
        {
            Cursos.Add(curso);
            curso.AdicionarAlunoCurso(aluno);
            
        }
        public override void Imprimir()
        {
            Console.WriteLine($"O aluno {Nome} está matriculado nos seguintes cursos: ");
            Console.WriteLine("");
            foreach (var curso in Cursos)
            {
                Console.WriteLine(curso.Nome);
            }
            Console.WriteLine("");
        }
    }
}
