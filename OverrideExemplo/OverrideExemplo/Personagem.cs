using System;
using System.Collections.Generic;
using System.Text;

namespace OverrideExemplo
{
    internal class Personagem
    {
        public string nome {  get; set; }
        public int nivel { get; set; }
        public int vida { get; set; }

        public virtual void Atacar()
        {
           Console.WriteLine("Tipo de ataque");
        }
        public virtual void UsarHabilidade()
        {
            Console.WriteLine("Habilidade");
        }
        public virtual double CalcularDano()
        {
            return 100;
        }


    }
}
