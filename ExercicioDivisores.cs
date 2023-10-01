using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso
{
    class ExercicioDivisores
    {
        public void Divisores()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();   

            for (int i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                    Console.WriteLine(i);
                }
            }
        }
    }
}
