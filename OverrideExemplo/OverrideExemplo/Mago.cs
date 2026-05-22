using System;
using System.Collections.Generic;
using System.Text;

namespace OverrideExemplo
{
    internal class Mago : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine("Ataque com magia");
        }
        public override void UsarHabilidade()
        {
            Console.WriteLine("Poção venenosa");
        }

        public override double CalcularDano()
        {
            return 700;
        }
    }
}
