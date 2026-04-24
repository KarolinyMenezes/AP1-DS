using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Paciente
    {
        private string _nome;
        private string _CPF;
        private string _senhaDeChamada;
        private string _sintomas;

        public Paciente(string nome, string CPF, string senhaDeChamada, string sintomas)
        {
            this._nome = nome;
            this._CPF = CPF;
            this._senhaDeChamada = senhaDeChamada;
            this._sintomas = sintomas;
        }
        public Paciente()
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
        public string get_CPF()
        {
            return this._CPF;
        }
        public void set_CPF(string CPF)
        {
            this._CPF = CPF;
        }
        public string get_senhaDeChamada()
        {
            return this._senhaDeChamada;
        }
        public void set_senhaDeChamada(string senhaDeChamada)
        {
            this._senhaDeChamada = senhaDeChamada;
        }
        public string get_sintomas()
        {
            return this._sintomas;
        }
        public void set_sintomas(string sintomas)
        {
            this._sintomas = sintomas;
        }
    }
}
