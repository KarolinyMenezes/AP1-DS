using System;
using System.Collections.Generic;
using System.Text;

namespace OverrideExemplo
{
    internal class Arqueiro : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine("Ataque à distância");
        }
        public override void UsarHabilidade()
        {
            Console.WriteLine("Flechas de fogo");
        }

        public override double CalcularDano()
        {
            return 500;
        }
    }
}
