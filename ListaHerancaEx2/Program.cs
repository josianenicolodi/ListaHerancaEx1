using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaHerancaEx2
{
    class Program
    {
        static Random rd = new Random();

        static string[] names = { "Maria", "Lucas", "Joana", "Mario" , "Fernando", "Felias", "Ruan", "Luica",
         "Carlo", "Brian", "Bart", "Mathias", "Fred", "Cathai", "Junior" , "LOla", "Athena", "carina", "Frederico"};
        static string[] lastName = { "Silva", "Pinto", "Snow", "Barbosa", "Rinosa", "Ferreria", "Junnos" };


        static string CreateName()
        {
            return names[rd.Next(names.Length)] + " " + lastName[rd.Next(lastName.Length)];
        }


        private static void InicializaVetores(Programador[] programadores, Analista[] analistas, Gerente[] Gerentes)
        {
            for (int i = 0; i < 10; i++)
            {
                int time = rd.Next(10);
                double sala = rd.Next(1, 3) * 1550f;
                sala += (time * 1.7d);

                programadores[i] = new Programador(CreateName(), time, sala);

            }

            for (int i = 0; i < 5; i++)
            {
                int time = rd.Next(10);
                double sala = rd.Next(2, 5) * 1550f;
                sala += (time * 1.7d);
                analistas[i] = new Analista(CreateName(), time, sala);
            }

            for (int i = 0; i < 3; i++)
            {
                int time = rd.Next(10);
                double sala = rd.Next(5, 12) * 1550f;
                sala += (time * 1.7d);
                Gerentes[i] = new Gerente(CreateName(), time, sala);

            }
        }

        static double MediaSalarios(Funcionarios[] funci)
        {
            double media = 0;
            for (int i = 0; i < funci.Length; i++)
            {
                media += funci[i].Dinheiro;
            }

            return media / funci.Length;
        }

        static float MediaIdade(Funcionarios[] funcio)
        {
            float media = 0;
            foreach (var item in funcio)
            {
                media += item.Idade;
            }
            return media / funcio.Length;
        }



        static Funcionarios MaisVelho(Funcionarios[] funcio)
        {
            Funcionarios maior = funcio[0];
            foreach (var item in funcio)
            {
                if (maior.Idade > item.Idade)
                {
                    maior = item;
                }
            }
            return maior;
        }

        static Funcionarios MaiorSalario(Funcionarios[] funcionarios)
        {

            Funcionarios maior = funcionarios[0];
            foreach (var item in funcionarios)
            {
                if (maior.Dinheiro < item.Dinheiro)
                {
                    maior = item;
                }
            }
            return maior;
        }

        static Funcionarios MaiorSalario(Funcionarios[] pro, Funcionarios[] analis, Funcionarios[] gerente)
        {
            return MaiorSalario(new Funcionarios[] { MaiorSalario(pro), MaiorSalario(analis), MaiorSalario(gerente) });
        }

        static Funcionarios MaisVelho(Funcionarios[] pro, Funcionarios[] analis, Funcionarios[] gerente)
        {
            return MaisVelho(new Funcionarios[] { MaisVelho(pro), MaisVelho(analis), MaisVelho(gerente) });
        }


        static void Main(string[] args)
        {
            Programador[] programadores = new Programador[10];
            Analista[] analistas = new Analista[5];
            Gerente[] gerentes = new Gerente[3];

            InicializaVetores(programadores, analistas, gerentes);

            double media = MediaSalarios(programadores);
            media += MediaSalarios(analistas);
            media += MediaSalarios(gerentes);
            media = media / 3;
            Console.WriteLine("A media de salario é: {0:C}", media);
            media = MediaIdade(programadores);
            media += MediaIdade(analistas);
            media += MediaIdade(gerentes);
            media /= 3;
            Console.WriteLine("A media de idade é: {0:F}", media);

            Console.WriteLine("O amiro salario é: {0:C}",MaiorSalario(programadores,analistas,gerentes).Dinheiro);


            Funcionarios maisVelho = MaisVelho(programadores);







            Console.ReadKey();
        }
    }
}
