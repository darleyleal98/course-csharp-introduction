using CSharpCursoIntroducao;
using System;
using System.Globalization;

namespace CSharpCursoIntroducao
{
    class PlanoCartesiano
    {
        public void Equacao()
        {
            Console.WriteLine("Digite o valor de X e Y: ");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 &&  y > 0)
                {
                    Console.WriteLine("1º Quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("2º Quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("3º Quadrante");
                }
                else
                {
                    Console.WriteLine("4º Quadrante");
                }

                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}