namespace SistemaEscola
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            this.Idade = idade;
        }

        public virtual void Imprimir()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Idade);
        }
    }
}
