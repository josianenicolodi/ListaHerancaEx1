using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaHerancaEx2
{
    class Programador : Funcionarios
    {

        string linguagem;

       


        public Programador(string nome, int idade, double salario) : base(nome)
        {
            this.salario = salario;
            this.idade = idade;
        }
    }
}
