using System;
using System.Globalization;
namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o nome do aluno");
            string nomeAluno = Console.ReadLine();
            Console.WriteLine("Escreva a primeira nota");
            double nota01 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Escreva a segunda nota");
            double nota02 = double.Parse(Console.ReadLine());
            double media = (nota01 + nota02) / 2;
            Console.WriteLine("sua média foi;" + media);
            Console.WriteLine("digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());


        if (media > 6.9 && faltas < 3 ) {
            Console.WriteLine(" Aprovado");
        }

        else  {
               

            Console.WriteLine("Reprovado");
            }
        Console.ReadLine();
    }

        
    }
}