using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Lanche
    {
        private string _pão;
        private string _molho;
        private string _carne;
        private string _salada;

        public Lanche(string pão, string molho, string carne, string salada)
        {
            this._pão = pão;
            this._molho = molho;
            this._carne = carne;
            this._salada = salada;
        }
        public Lanche()
        {
        }
        public string get_pão()
        {
            return this._pão;
        }
        public void set_pão(string pão)
        {
            this._pão = pão;
        }
        public string get_molho()
        {
            return this._molho; 
        }
        public void set_molho(string molho)
        {
            this._molho = molho;
        }
        public string get_carne()
        {
            return this._carne; 
        }
        public void set_carne(string carne)
        {
            this._carne = carne;
        }
        public string get_salada()
        {
            return this._salada;
        }
        public void set_salada(string salada)
        {
            this._salada = salada;
        }

    }   

}
