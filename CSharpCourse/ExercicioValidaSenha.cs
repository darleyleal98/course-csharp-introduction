using System;
using System.Collections.Generic;
using CSharpCursoIntroducao;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoIntroducao
{
    class ValidacaoSenha
    {
        public void ValidaSenha()
        {
            Console.Write("Digite sua senha: ");
            double senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida, tente novamente!");
                senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Acesso permitido!");
            }
        }
    }
}