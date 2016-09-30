using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaHerancaEx2
{
    class Funcionarios
    {
        protected string nome;
        protected int idade;
        protected double salario;


        public double Dinheiro
        {
            get
            {
                return salario;
            }
        }
        public int Idade
        {
            get
            {
                return idade;
            }
        }

        public Funcionarios(string nome)
        {
            this.nome = nome;
        }

    }
}
