using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Carro
    {
        private string _motor;
        private string _rodas;
        private string _volante;
        private string _marca;
        public Carro()
        {
            this._motor = null;
            this._rodas = null;
            this._volante = null;
            this._marca = null;
        }
        public Carro(string motor, string rodas, string volante, string assentos)
        {
            this._motor = null;
            this._rodas = null;
            this._volante = null;
            this._marca = null;
        }
        public string get_motor ()
        {
            return this._motor; 
        }
        public void set_motor(string motor)
        {
            this._motor = motor;
        }
        public string get_rodas ()
        {
            return this._rodas;
        }
        public void set_rodas(string rodas)
        {
            this._rodas = rodas;
        }
        public string get_volante()
        {
            return this._volante; 
        }
        public void set_volante(string volante)
        {
            this._volante = volante;
        }
        public string get_marca()
        {
            return this._marca;
        }
        public void set_assentos(string assentos)
        {
            this._marca = assentos;
        }




    }
}
