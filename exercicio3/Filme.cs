using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Filme
    {
        private string _falas;
        private string _açoes;
        private string _genero;
        private string _classificaçao;

        public Filme(string falas, string açoes, string genero, string classificaçao)
        {
            this._falas = falas;
            this._açoes = açoes;
            this._genero = genero;
            this._classificaçao = classificaçao;
        }
        public Filme()
        {
        }
        public string get_falas()
        {
            return this._falas;
        }
        public void set_falas(string falas)
        {
            this._falas = falas;
        }
        public string get_açoes()
        {
            return this._açoes;
        }
        public void set_açoes(string açoes)
        {
            this._açoes = açoes;
        }
        public string get_genero()
        {
            return this._genero;
        }
        public void set_genero(string genero)
        {
            this._genero = genero;
        }
        public string get_classificaçao()
        {
            return this._classificaçao;
        }
        public void set_classificaçao(string classificaçao)
        {
            this._classificaçao = classificaçao;
        }
    }
}
