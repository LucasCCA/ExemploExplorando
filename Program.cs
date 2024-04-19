using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

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

#region FormatandoMoedas

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

// DateTime data = DateTime.Now;
// DateTime data2 = DateTime.Parse("17/04/2022 18:00");

// string dataString = "2022-04-17 18:00";
// bool sucesso = DateTime.TryParseExact(
//     dataString, "yyyy-MM-dd HH:mm",
//     CultureInfo.InvariantCulture,
//     DateTimeStyles.None,
//     out DateTime data3);

// Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());
// Console.WriteLine(data2);

// if (sucesso)
// {
//     Console.WriteLine(data3);
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

#endregion

#region ExcecaoComLeituraDeArquivo

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }

#endregion

#region Throw

// new ExemploExcecao().Metodo1();

#endregion

#region Fila

// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

#endregion

#region Pilha

// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

#endregion

#region Dictionary

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("-----------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach (KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// Console.WriteLine(estados["MG"]);

#endregion

#region Tuplas

// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Lucas", "Cândido", 1.8M);
// ValueTuple<int, string, string, decimal> tupla2 = (1, "Lucas", "Cândido", 1.8M);
// var tupla3 = Tuple.Create(1, "Lucas", "Cândido", 1.8M);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");

// Console.WriteLine($"Id: {tupla2.Item1}");
// Console.WriteLine($"Nome: {tupla2.Item2}");
// Console.WriteLine($"Sobrenome: {tupla2.Item3}");
// Console.WriteLine($"Altura: {tupla2.Item4}");

// Console.WriteLine($"Id: {tupla3.Item1}");
// Console.WriteLine($"Nome: {tupla3.Item2}");
// Console.WriteLine($"Sobrenome: {tupla3.Item3}");
// Console.WriteLine($"Altura: {tupla3.Item4}");

// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// var (_, _, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); //Descarte

// if (sucesso)
// {
//     Console.WriteLine($"Quantidade linhas do arquivo: {quantidadeLinhas}");
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

#endregion

#region Desconstrutor

// Pessoa p1 = new Pessoa("Lucas", "Cândido");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

#endregion

#region OperadorTernario

// int numero = 10;
// bool par = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é {(par ? "par" : "ímpar")}");

#endregion

#region Serializacao

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, DateTime.Now);

// string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
// Console.WriteLine(serializado);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// List<Venda> listaVendas = new List<Venda>();
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, DateTime.Now);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string colecaoSerializada = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// Console.WriteLine(colecaoSerializada);

// File.WriteAllText("Arquivos/vendasColecao.json", colecaoSerializada);

#endregion

#region Deserializacao

string conteudoArquivo = File.ReadAllText("Arquivos/vendasColecao.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
        $"Preço: {venda.Preco}, Data: {venda.DataVenda:dd/MM/yyyy HH:mm}");
}

string conteudoArquivo2 = File.ReadAllText("Arquivos/vendaNomeForaDaConvencao.json");

List<Venda> listaVenda2 = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo2);

foreach (Venda venda in listaVenda2)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
        $"Preço: {venda.Preco}, Data: {venda.DataVenda:dd/MM/yyyy HH:mm}");
}

#endregion
