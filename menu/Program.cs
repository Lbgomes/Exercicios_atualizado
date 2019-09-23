using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma = "";
            do {


                Console.WriteLine("Escolha sua forma geométrica");
                Console.WriteLine("Quadrado, triângulo, circulo, trapézio, retângulo, losango");
                forma = Console.ReadLine();

                if (forma == "quadrado")
                {

                    Console.WriteLine("Escreva o tamanho do lado do quadrado");
                    double lquadrado = 0;
                    lquadrado = double.Parse(Console.ReadLine());
                    double resultquadrado = lquadrado * lquadrado;
                    Console.Write("Área do quadrado  = " + resultquadrado);
                }
                else if (forma == "triangulo")
                {

                    Console.WriteLine("Escreva o tamanho da base do triângulo");
                    double basetriangulo = 0;
                    basetriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva o tamanho da altura");
                    double alturatriangulo = 0;
                    alturatriangulo = double.Parse(Console.ReadLine());
                    double resultriangulo = basetriangulo * alturatriangulo;
                    Console.Write("Área do triângulo  = " + resultriangulo);
                }
                else if (forma == "retangulo")
                {

                    Console.WriteLine("Escreva o tamanho da base do retângulo");
                    double baseretangulo = 0;
                    baseretangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva o tamanho da altura");
                    double alturaretangulo = 0;
                    alturaretangulo = double.Parse(Console.ReadLine());
                    double resulretangulo = baseretangulo * alturaretangulo;
                    Console.Write("Área do retângulo  = " + resulretangulo);
                }
                else if (forma == "circulo")
                {

                    Console.WriteLine("Escreva o tamanho do raio desse circulo");
                    double raio = 0;
                    raio = double.Parse(Console.ReadLine());
                    double resulcirculo = (3.14 * (raio * raio));
                    Console.Write("Área do circulo  = " + resulcirculo);
                }
                else if (forma == "circulo")
                {

                    Console.WriteLine("Escreva o tamanho do raio desse circulo");
                    double raio = 0;
                    raio = double.Parse(Console.ReadLine());
                    double resulcirculo = (3.14 * (raio * raio));
                    Console.Write("Área do circulo  = " + resulcirculo);
                }
                else if (forma == "trapezio")
                {

                    Console.WriteLine("Escreva o tamanho da base menor do trapezio");
                    double basemetrapezio = 0;
                    basemetrapezio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva o tamanho da base maior do trapezio");
                    double basematrapezio = 0;
                    basematrapezio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva o tamanho da altura");
                    double alturatrapezio = 0;
                    alturatrapezio = double.Parse(Console.ReadLine());
                    double resulretangulo = basemetrapezio * basematrapezio * alturatrapezio / 2;
                    Console.Write("Área do trapézio  = " + resulretangulo);
                }
                else if (forma == "losango")
                {

                    Console.WriteLine("Escreva a medida da diagonal menor");
                    double dimenor = 0;
                    dimenor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escreva a medida da diagonal maior");
                    double dimaior = 0;
                    dimaior = double.Parse(Console.ReadLine());
                    double resulosango = dimenor * dimaior / 2;
                    Console.Write("Área do losango  = " + resulosango);
                }
            }
           }
    }
}
