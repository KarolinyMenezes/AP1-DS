// See https://aka.ms/new-console-template for more information
using ConsoleApp3;

Filme f = new Filme();

Console.WriteLine("Quais falas?");
f.set_falas(Console.ReadLine());

Console.WriteLine("Quais ações?");
f.set_açoes(Console.ReadLine());

Console.WriteLine("Qual gênero?");
f.set_genero(Console.ReadLine());

Console.WriteLine("Qual classificação?");
f.set_classificaçao(Console.ReadLine());

Console.WriteLine(string.Concat("Seu filme é: ", f.get_falas(), " ", f.get_açoes(), " ", f.get_genero(), " ", f.get_classificaçao()));
