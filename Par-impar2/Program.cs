using System;

namespace Par_impar2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[6];

            foreach (int item in vetor)
            {
                vetor[item] = item;



            }
            Console.WriteLine("Insira o primeiro numero inteiro");
            vetor[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero inteiro");
            vetor[1] = int.Parse(Console.ReadLine());


            Console.WriteLine("Insira o terceiro numero inteiro");
            vetor[2] = int.Parse(Console.ReadLine());


            Console.WriteLine("Insira o quarto numero inteiro");
            vetor[3] = int.Parse(Console.ReadLine());


            Console.WriteLine("Insira o quinto numero inteiro");
            vetor[4] = int.Parse(Console.ReadLine());


            Console.WriteLine("Insira o sexto numero inteiro");
            vetor[5] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                if ( (vetor[i] % 2) != 0)
                {
                    Console.WriteLine($"{i +1}")
                    

                   
 

}
            }



        }
    }
}
