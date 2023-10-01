using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpCursoIntroducao
{
    class MediaPonderada
    {
        public void MediaPonderadaExercicio()
        {
            Console.WriteLine("Quantas vezes você quer que o programa repita? ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                
                double a = double.Parse(vetor[0]);
                double b = double.Parse(vetor[1]);
                double c = double.Parse(vetor[2]);

                double mediaPonderada = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                Console.WriteLine(mediaPonderada.ToString("F1"));
            }  
        }
    }
}
