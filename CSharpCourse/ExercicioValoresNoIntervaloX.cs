using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using CSharpCursoIntroducao;
using System.Threading.Tasks;

namespace CSharpCursoIntroducao
{
    class ValoresNoIntervaloX
    {
        public void ValorInteiro()
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int contadorIn = 0;
            int contadorOut = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    contadorIn += 1;
                }
                else
                {
                    contadorOut += 1;
                }
            }
            Console.WriteLine($"{contadorIn} in");
            Console.WriteLine($"{contadorIn} out");
        }
    }
}
