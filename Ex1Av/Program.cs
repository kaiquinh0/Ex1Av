using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Av
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que receba o nome do aluno, nota de trabalho, nota da prova 1 e nota da prova 2. 
            Calcule a média  final (média simples) e apresente o conceito obtido seguindo a seguinte formula O conceito da será calculado da seguinte forma:
            Se a nota final for maior ou igual a 8.5, então o conceito é A.
            Se a nota final estiver entre 7.0 e 8.4, então o conceito é B.
            Se a nota final estiver entre 6.0 e 6.9, então o conceito é C.
            Se a nota final estiver entre 0.1 e 5.9, então o conceito é D.
            Se a nota final for igual a 0.0, então o conceito é E.*/

            double trabalho, n1, n2, media;
            string nome;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a nota do trabalho: ");
            trabalho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            media = (n1 + n2 + trabalho) / 3;
            if (media >= 8.5)
            {
                Console.WriteLine(String.Format("A média do aluno {0} é {1}. Conceito final é A.", nome, media.ToString("f")));
            }
            if (media > 7 && media < 8.4)
            {
                Console.WriteLine(String.Format("A média do aluno {0} é {1}. Conceito final é B.", nome, media.ToString("f")));
            }
            if (media > 6 && media < 6.9)
            {
                Console.WriteLine(String.Format("A média do aluno {0} é {1}. Conceito final é C.", nome, media.ToString("f")));
            }
            if (media > 0.1 && media < 5.9)
            {
                Console.WriteLine(String.Format("A média do aluno {0} é {1}. Conceito final é D.", nome, media.ToString("f")));
            }
            if (media == 0)
            {
                Console.WriteLine(String.Format("A média do aluno {0} é {1}. Conceito final é E.", nome, media.ToString("f")));
            }
            Console.ReadKey();

        }
    }
}
