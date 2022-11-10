using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isi
{
    internal class Veiculo
    {
        string nome;
        int ano;
        int preco;
        int km;
        string fuel;
        string transmissao;
        string n_dono;
        string tipo_dono;

        #region Construtor
        public Veiculo(string nome, int ano, int preco, int km, string fuel, string transmissao, string n_dono, string tipo_dono)
        {
            this.nome = nome;
            this.ano = ano;
            this.preco = preco;
            this.km = km;
            this.fuel = fuel;
            this.transmissao = transmissao;
            this.n_dono = n_dono;
            this.tipo_dono = tipo_dono;
        }
        #endregion

        #region Properties
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public int Preco
        {
            get { return preco; }
            set
            {
                preco = value;
            }
        }
        public int Km
        {
            get { return km; }
            set
            {
                km = value;
            }
        }
        public string Fuel
        {
            get { return fuel; }
            set
            {
                fuel = value;
            }
        }
        public string Transmissao
        {
            get { return transmissao; }
            set
            {
                transmissao = value;
            }
        }
        public string N_dono
        {
            get { return n_dono; }

            set
            {
                n_dono = value;
            }
        }

        public string Tipo_dono
        {
            get { return tipo_dono; }
            set
            {
                tipo_dono = value;
            }
        }
        #endregion


    }
}
