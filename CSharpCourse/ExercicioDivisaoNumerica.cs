using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCursoIntroducao;

namespace CSharpCursoIntroducao
{
    class ExercicioDivisaoNumerica
    {
        public void DivisaoNumerica()
        {
            Console.WriteLine("Digite a quantidade de tentativas");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite dois números");
                string[] vetor = Console.ReadLine().Split(' ');

                double a = double.Parse(vetor[0]);
                double b = double.Parse(vetor[1]);

                if (b == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }

                else
                {
                    double resultado = a / b;
                    Console.WriteLine(resultado);
                }
            }
        }
    }
}
