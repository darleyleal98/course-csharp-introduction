using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCursoIntroducao;

namespace CSharpCursoIntroducao
{
    class ExercicioFatorial
    {
        public void  Fatorial()
        {
            int n = int.Parse(Console.ReadLine());
            int fatorial;

            for (fatorial = 1; n > 1; n--)
            {
                fatorial *= n;
            }
            Console.WriteLine(fatorial);
        }
    }
}
