using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Cândido");

Pessoa p2 = new Pessoa(nome: "João", sobrenome: "Silva");

Curso ingles = new Curso()
{
    Nome = "Inglês",
    Alunos = new List<Pessoa>()
};

ingles.AdicionarAluno(p1);
ingles.AdicionarAluno(p2);
ingles.ListarAlunos();