using System;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Puis-je avoir votre nom, votre prénom et votre âge ?");

            string v1;
            v1 = Console.ReadLine();
            string v2;
            v2 = Console.ReadLine();
            int firstNumber;
            firstNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Nom : " + v1);
            Console.WriteLine("Prénom : " + v2);
            Console.WriteLine("Âge : " + firstNumber);


        }
    }
}
