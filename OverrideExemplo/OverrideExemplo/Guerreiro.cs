using System;
using System.Collections.Generic;
using System.Text;

namespace OverrideExemplo
{
    internal class Guerreiro : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine("Ataque corpo a corpo");
        }
        public override void UsarHabilidade()
        {
            Console.WriteLine("Super soco");
        }

        public override double CalcularDano()
        {
            return 1000;
        }
    }
}
