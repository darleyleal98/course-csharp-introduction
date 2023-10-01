using CSharpCursoIntroducao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoIntroducao
{
    class NumerosImpares
    {
        public void EncontraNumeroImpar()
        {
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                if (i % 2 > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
