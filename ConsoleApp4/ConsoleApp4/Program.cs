// See https://aka.ms/new-console-template for more information
using ConsoleApp4;

Jogador j = new Jogador();

Console.WriteLine("Qual o nome?");
j.set_nome(Console.ReadLine());

Console.WriteLine("Qual o sexo?");
j.set_sexo(Console.ReadLine());

Console.WriteLine("Qual o time?");
j.set_time(Console.ReadLine());

Console.WriteLine("Qual o número da camisa?");
j.set_numeroCamisa(Console.ReadLine());

Console.WriteLine(string.Concat("Seu Jogador é: ", j.get_nome(), " ", j.get_sexo(), " ", j.get_time(), " ", j.get_numeroCamisa()));
