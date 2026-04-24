// See https://aka.ms/new-console-template for more information
using ConsoleApp5;

Paciente p = new Paciente();

Console.WriteLine("Nome do paciente?");
p.set_nome(Console.ReadLine());

Console.WriteLine("Qual o CPF?");
p.set_CPF(Console.ReadLine());

Console.WriteLine("Qual a senha de chamada?");
p.set_senhaDeChamada(Console.ReadLine());

Console.WriteLine("Quais os sintomas?");
p.set_sintomas(Console.ReadLine());

Console.WriteLine(string.Concat("Seu Paciente é: ", p.get_nome(), " ", p.get_CPF(), " ", p.get_senhaDeChamada(), " ", p.get_sintomas()));
