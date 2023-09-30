using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite sua senha: ");
            double senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida, tente novamente!");
                senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Acesso permitido!");
        }
    }
}