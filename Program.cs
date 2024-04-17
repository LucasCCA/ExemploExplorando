using ExemploExplorando.Models;
using System.Globalization;

#region BodyExpression

// Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Cândido");

// Pessoa p2 = new Pessoa(nome: "João", sobrenome: "Silva");

// Curso ingles = new Curso()
// {
//     Nome = "Inglês",
//     Alunos = new List<Pessoa>()
// };

// ingles.AdicionarAluno(p1);
// ingles.AdicionarAluno(p2);
// ingles.ListarAlunos();

#endregion

#region FormatandoNumeros

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 82.4M;

// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("C8"));
// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

#endregion

#region FormatandoDatas

DateTime data = DateTime.Now;
DateTime data2 = DateTime.Parse("17/04/2022 18:00");

string dataString = "2022-04-17 18:00";
bool sucesso = DateTime.TryParseExact(
    dataString, "yyyy-MM-dd HH:mm",
    CultureInfo.InvariantCulture,
    DateTimeStyles.None,
    out DateTime data3);

Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(data2);

if (sucesso)
{
    Console.WriteLine(data3);
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

#endregion
