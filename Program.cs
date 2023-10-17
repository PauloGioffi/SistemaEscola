using SistemaEscola;

class Program
{
    static void Main()
    {
        Aluno aluno1 = new("Paulo", 25, 1501);
        Aluno aluno2 = new("Flavia", 19, 2567);
        Aluno aluno3 = new("Pedro", 21, 1748);
        Aluno aluno4 = new("Samuel", 25, 1255);
        Aluno aluno5 = new("Eduarda", 19, 2539);
        

        Curso curso1 = new("ADS", 22);
        Curso curso2 = new("ADM", 77);
        Curso curso3 = new("Enfermagem", 56);

        Disciplina disciplina1 = new("Lógica de Programação", 64, "Abordagem contextual quanto à Lógica de Programação.");
        Disciplina disciplina2 = new("Banco de Dados", 72, "Abordagem contextual quanto à Banco de Dados.");
        Disciplina disciplina3 = new("POO", 80, "Abordagem contextual quanto à POO.");
        Disciplina disciplina4 = new("Contabilidade", 64, "Abordagem contextual quanto à Contabilidade.");
        Disciplina disciplina5 = new("Tributação", 64, "Abordagem contextual quanto à Tributação.");
        Disciplina disciplina6 = new("Gestão", 72, "Abordagem contextual quanto à Gestão.");
        Disciplina disciplina7 = new("Primeiros Socorros", 72, "Abordagem contextual quanto à Lógica de Programação.");
        Disciplina disciplina8 = new("Anatomia", 80, "Abordagem contextual quanto à Lógica de Programação.");
        Disciplina disciplina9 = new("Farmacologia", 80, "Abordagem contextual quanto à Lógica de Programação.");

        Professor professor1 = new("Sergio", 37);
        Professor professor2 = new("Daniela", 33);
        Professor professor3 = new("Monique", 56);
        Professor professor4 = new("José", 69);

        aluno1.MatricularAluno(aluno1, curso1);
        aluno1.MatricularAluno(aluno1, curso2);
        aluno2.MatricularAluno(aluno2, curso1);
        aluno3.MatricularAluno(aluno3, curso1);
        aluno3.MatricularAluno(aluno3, curso2);
        aluno3.MatricularAluno(aluno3, curso3);
        aluno4.MatricularAluno(aluno4, curso2);
        aluno4.MatricularAluno(aluno4, curso3);
        aluno5.MatricularAluno(aluno5, curso3);

        aluno1.Imprimir();
        aluno2.Imprimir();
        aluno3.Imprimir();
        aluno4.Imprimir();
        aluno5.Imprimir();

        curso1.ListarAlunosCurso();
        curso2.ListarAlunosCurso();
        curso3.ListarAlunosCurso();
        
        curso1.AdicionarDisciplinaCurso(disciplina1);
        curso1.AdicionarDisciplinaCurso(disciplina2);
        curso1.AdicionarDisciplinaCurso(disciplina3);
        curso2.AdicionarDisciplinaCurso(disciplina4);
        curso2.AdicionarDisciplinaCurso(disciplina5);
        curso2.AdicionarDisciplinaCurso(disciplina6);
        curso2.AdicionarDisciplinaCurso(disciplina7);
        curso3.AdicionarDisciplinaCurso(disciplina8);
        curso3.AdicionarDisciplinaCurso(disciplina9);

        curso1.ListarDisciplinaCurso();
        curso2.ListarDisciplinaCurso();
        curso3.ListarDisciplinaCurso();

        professor1.AdicionarDisciplinasProfessor(disciplina9);
        professor1.AdicionarDisciplinasProfessor(disciplina7);
        professor2.AdicionarDisciplinasProfessor(disciplina5);
        professor3.AdicionarDisciplinasProfessor(disciplina1);
        professor3.AdicionarDisciplinasProfessor(disciplina2);
        professor3.AdicionarDisciplinasProfessor(disciplina3);
        professor4.AdicionarDisciplinasProfessor(disciplina4);
        professor4.AdicionarDisciplinasProfessor(disciplina6);
        professor3.AdicionarDisciplinasProfessor(disciplina8);

        professor1.Imprimir();
        professor2.Imprimir();
        professor3.Imprimir();
        professor4.Imprimir();




    }
}
