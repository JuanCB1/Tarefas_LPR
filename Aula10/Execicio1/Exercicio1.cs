/*Exercício 1)
a) Fazer um programa para ler os valores
da largura e altura de um retângulo. Em
seguida, mostrar na tela o valor de sua
área e perímetro.
Usar a seguinte classe:
---------------
Retangulo
---------------
double Altura
double Largura
---------------
calcArea()
calcPerimetro()
*/
using System;

class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public double CalcArea()
    {
        return Altura * Largura;
    }

    public double CalcPerimetro()
    {
        return 2 * (Altura + Largura);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Retangulo ret = new Retangulo();

        Console.Write("Digite a largura do retângulo: ");
        ret.Largura = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        ret.Altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nÁrea do retângulo: {ret.CalcArea()}");
        Console.WriteLine($"Perímetro do retângulo: {ret.CalcPerimetro()}");

        Console.ReadKey();
    }
}
