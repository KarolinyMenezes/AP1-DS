using OverrideExemplo;

Personagem p1 = new Guerreiro();
Personagem p2 = new Arqueiro();
Personagem p3 = new Mago();

p1.nome = "Brutus";
p2.nome = "Robin Hood";
p3.nome = "Harry Potter";

p1.nivel = 500;
p2.nivel = 300;
p3.nivel = 450;

p1.vida = 100;
p2.vida = 100;
p3.vida = 1000;

Console.WriteLine("Guerreiro " + p1.nome + " nível " + p1.nivel + " e vida " + p1.vida + "\nAtaque:");
p1.Atacar();
Console.WriteLine("Habilidade:");
p1.UsarHabilidade();
Console.WriteLine("Dano:");
Console.WriteLine(p1.CalcularDano());

Console.WriteLine("\nArqueiro " + p2.nome + " nível " + p2.nivel + " e vida " + p2.vida + "\nAtaque:");
p2.Atacar();
Console.WriteLine("Habilidade:");
p2.UsarHabilidade();
Console.WriteLine("Dano:");
Console.WriteLine(p2.CalcularDano());

Console.WriteLine("\nMago " + p3.nome + " nível " + p3.nivel + " e vida " + p3.vida + "\nAtaque:");
p3.Atacar();
Console.WriteLine("Habilidade:");
p3.UsarHabilidade();
Console.WriteLine("Dano:");
Console.WriteLine(p3.CalcularDano());


Console.ReadKey();
