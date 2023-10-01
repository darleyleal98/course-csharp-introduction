using System;
using System.Collections.Generic;
using System.Linq;
using CSharpCursoIntroducao;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoIntroducao
{
    class ExercicioPostoCombustivel
    {
        public void TipoCombustivel()
        {
            Console.WriteLine("Escolha um tipo de combustível: \n" +
                              "1 - Álcool \n" +
                              "2 - Gasolina \n" +
                              "3 - Diesel \n" +
                              "4 - Sair \n");

            int opcao = int.Parse(Console.ReadLine());
            int contagemClientes = 0;

            while (opcao != 4)
            {
                if (opcao == 1)
                {
                    contagemClientes++;
                    Console.WriteLine($"Álcool: {contagemClientes}");
                }
                else if (opcao == 2)
                {
                    contagemClientes++;
                    Console.WriteLine($"Gasolina: {contagemClientes}");
                }
                else if (opcao == 3)
                {
                    contagemClientes++;
                    Console.WriteLine($"Diesel: {contagemClientes}");
                }
                else
                {
                    Console.WriteLine("Muito obrigado!");
                }

                opcao = int.Parse(Console.ReadLine());
            }
        }
    }
}
