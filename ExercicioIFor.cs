using CSharpCursoIntroducao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoIntroducao
{
    class ExercicioIFor
    {
        public void For()
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int repeticao = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < repeticao; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                int valores = int.Parse(Console.ReadLine());
                soma += valores;
            }

            Console.WriteLine($"Soma = {soma}");
        }
    }
}
