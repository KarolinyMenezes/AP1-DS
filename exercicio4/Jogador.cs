using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Jogador
    {
        private string _nome;
        private string _sexo;
        private string _time;
        private string _numeroCamisa;

        public Jogador(string nome, string sexo, string time, string numeroCamisa)
        {
            this._nome = nome;
            this._sexo = sexo;
            this._time = time;
            this._numeroCamisa = numeroCamisa;
        }
        public Jogador()
        {
        }
        public string get_nome()
        {
            return this._nome;
        }
        public void set_nome(string nome)
        {
            this._nome = nome;
        }
        public string get_sexo()
        {
            return this._sexo;
        }
        public void set_sexo(string sexo)
        {
            this._sexo = sexo;
        }
        public string get_time()
        {
            return this._time;
        }
        public void set_time(string time)
        {
            this._time = time;
        }
        public string get_numeroCamisa()
        {
            return this._numeroCamisa;
        }
        public void set_numeroCamisa(string numeroCamisa)
        {
            this._numeroCamisa = numeroCamisa;
        }

    }
}
