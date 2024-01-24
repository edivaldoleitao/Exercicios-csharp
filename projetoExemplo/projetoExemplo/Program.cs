// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;
using projetoExemplo.Common.Models;
using System.Globalization;
using System.Runtime.InteropServices;


// DateTime dt1 = DateTime.Now;
// DateTime dt2 = new DateTime(2023,12,26,22,00,00);

// decimal CalcularTempo(DateTime dt1, DateTime dt2, decimal precoInicial, decimal precoHora) 
// {
//     double horas = (dt1 - dt2).TotalHours; 
//     decimal result = precoInicial + precoHora*(decimal)horas; 

//    Console.WriteLine(horas);
//    return result;
// }


// Console.WriteLine($"{CalcularTempo(dt1,dt2,1,2):C}");




//Herança e polimorfismo =================================================================
//====================================================================================
//polimorfismo em tempo de execução 
// Pessoa aluno = new Aluno();
// aluno.Apresentar();
//coleções e estruturas =====================================================
//========================================================================
// Queue<int> fila = new Queue<int>();//fila
// fila.Enqueue(9);
// fila.Enqueue(3);
// Console.WriteLine(fila.Dequeue());

// Stack<int> pilha = new Stack<int>();// pilha

// pilha.Push(1);
// pilha.Push(5);

// Console.WriteLine(pilha.Pop());

// Dictionary<string, string> estados = new Dictionary<string, string>(); //dicionario

// estados.Add("PE","pernambuco");
// estados.Add("Ba","bahia");
// estados.Add("SP", "sao paulo");

// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"chave {estado.Key} valor {estado.Value}");
// }

// estados.Remove("PE");
// estados["SP"] = "valor modificado";

// foreach (KeyValuePair<string, string> estado in estados)
// {
//     Console.WriteLine($"chave {estado.Key} valor {estado.Value}");
// }







//subindo exceções================================================================
//==================================================================================
// ExemploExcecao e = new ExemploExcecao();
// e.Metodo1();

// ler arquivos | exceções ==============================================================
//=========================================================================================
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeiastura.txt");

//     foreach (string linha in linhas)
//     {
//     Console.WriteLine(linha);
//     }   
// }
// catch(FileNotFoundException ex) // exceção específica
// {
//     Console.WriteLine("não encontrou o arquivo: "+ex.Message);
// }
// catch (Exception ex) //exceção genérica
// {  
//     Console.WriteLine("exceção genérica: "+ex.Message);
// }
// finally //executa sempre por último
// {
//     Console.WriteLine("bloco do finally");
// }

// Console.WriteLine("continuação do programa");



// instanciar objetos de classes ==================================================
//==================================================================================
// Console.WriteLine("Hello, World!");

// Pessoa p = new(nome:"nome",idade:1);
// p.Nome = "name";

// Pessoa p2 = new(nome:"nome2",idade:2);

// Curso c = new Curso();
// c.Nome = "curso A";

// c.Alunos = new List<Pessoa>();
// c.AdicionaAluno(p);
// c.AdicionaAluno(p2);
// c.ListarAlunos();

// //casting ================================================================
//===========================================================================
// //valor nulo é convertido para 0
// int w = Convert.ToInt32("5");

// // valor nulo da erro
// w = int.Parse("7");
// Console.WriteLine(w);

// // valor convertido para string
//  string s = w.ToString();
//  Console.WriteLine($"{s} string");


// casting implicito

//int a = 5;
//long b = a;

//precisa do convert do maior para menor
// long b = 5;
// int a = Convert.ToInt32(b);

// string[] carr = {"1","2"};
// Console.WriteLine(string.Join(",",carr));


// herança em c# =======================================================================
//=======================================================================================
// class Subclasse : Personagem
// {
//     public int DanoBase { get; set; }

//     public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
//     {
//         DanoBase = danoBase;
//     }

//     public void CalcularDano()
//     {
//         Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
//     }
// }

// formatação da string para currency C2,para 2 casas decimais =============================================
//======================================================================================================
// decimal dinheiro = 56.78M;

// Console.WriteLine($"dinheiro: {dinheiro:C}"); //currency

// // mudar cultura localização para todo sistema

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// //MUDA SOMENTE NO TRECHO DO CóDIGO
// Console.WriteLine(dinheiro.ToString("C",CultureInfo.CreateSpecificCulture("en-US"))); //currency

// double porcent = 0.23;
// // porcentagem
// Console.WriteLine($"porcent: {porcent:P}");

// int numero = 123444;
// Console.WriteLine($"{numero:##-##-##}");

// // DATAS

// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yyyy - HH:mm"));

// string datastring = "2022-02-23 17:09";

// bool sucesso = DateTime.TryParseExact(datastring, "dd/MM/yyyy - HH:mm",
//                                     CultureInfo.InvariantCulture,
//                                     DateTimeStyles.None, out DateTime datastr);

// if (sucesso)
// {
//     Console.WriteLine("conversão sucesso: "+ datastr);
// }
// else
// {
//     Console.WriteLine("vc flopou");
// }