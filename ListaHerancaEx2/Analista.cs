using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaHerancaEx2
{
    class Analista : Funcionarios
    {

        string metodologia; 

      
        public Analista(string nome,int idade, double salario ) : base(nome)
        {
            this.salario = salario;
            this.idade = idade;
        }
    }

}
