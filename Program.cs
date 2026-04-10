// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Lanche l = new Lanche();

Console.WriteLine("Tamanho do pão?");
l.set_pão(Console.ReadLine());

Console.WriteLine("Qual molho?");
l.set_molho(Console.ReadLine());

Console.WriteLine("Qual carne?");
l.set_carne(Console.ReadLine());

Console.WriteLine("Com salada?");
l.set_salada(Console.ReadLine());

Console.WriteLine(string.Concat("Seu lanche é: ", l.get_pão(), " ", l.get_molho(), " ", l.get_carne(), " ", l.get_salada()));