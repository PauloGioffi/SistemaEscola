namespace SistemaEscola
{
    internal class Professor:Pessoa
    {
        public List<Disciplina> DisciplinasProfessor { get; set; }
        public Professor(string nome, int idade) : base(nome, idade)
        {
            
            this.DisciplinasProfessor = new();
        }
        public void AdicionarDisciplinasProfessor(Disciplina disciplina)
        {
            DisciplinasProfessor.Add(disciplina);
        }
        public override void Imprimir()
        {   
            
            Console.WriteLine($"Segue a lista de disciplinas lecionadas pelo professor {Nome}: ");
            Console.WriteLine("");
            foreach (var disciplina in DisciplinasProfessor)
            {
                Console.WriteLine(disciplina.Titulo);
            }
            Console.WriteLine("");
        }
        

        
    }
}
