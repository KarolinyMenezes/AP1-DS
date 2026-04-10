// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Carro c = new Carro();

Console.WriteLine("Qual a marca?");
c.set_motor(Console.ReadLine());

Console.WriteLine("Quais as rodas?");
c.set_rodas(Console.ReadLine());

Console.WriteLine("Qual o volante?");
c.set_volante(Console.ReadLine());

Console.WriteLine("Qual o motor?");
c.set_volante(Console.ReadLine());

Console.WriteLine(string.Concat("Seu carro é: ", c.get_motor()," ", c.get_rodas()," ", c.get_volante()," ", c.get_marca()));
