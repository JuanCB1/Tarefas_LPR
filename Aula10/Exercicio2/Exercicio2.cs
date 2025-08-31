/*Exercício 2)
A. Fazer um programa para ler os dados
de um funcionário (nome, salário bruto
e imposto).

B. A classe funcionário deve conter os
seguintes métodos:
- Mostrar os dados do funcionário (nome e
salário líquido).
- Aumentar o salário do funcionário com base
em uma porcentagem dada

C. OBS: Tabela de Imposto
- 10% para salários de até 2000
- 15% para salários de até 3000
- 20% para salários superiores a 3000
*/

using System;

class Funcionario
{
    public string Nome { get; set; }
    public double SalarioBruto { get; set; }
    public double Imposto { get; private set; }

    // Calcula o imposto com base na tabela
    public void CalcularImposto()
    {
        if (SalarioBruto <= 2000)
            Imposto = 0.10 * SalarioBruto;
        else if (SalarioBruto <= 3000)
            Imposto = 0.15 * SalarioBruto;
        else
            Imposto = 0.20 * SalarioBruto;
    }

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    // Aumenta o salário com base na porcentagem informada
    public void AumentarSalario(double percentual)
    {
        SalarioBruto += SalarioBruto * (percentual / 100.0);
        CalcularImposto(); 
    }

    public void MostrarDados()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Salário líquido: {SalarioLiquido():F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario();

        Console.Write("Digite o nome do funcionário: ");
        func.Nome = Console.ReadLine();

        Console.Write("Digite o salário bruto: ");
        func.SalarioBruto = double.Parse(Console.ReadLine());

        func.CalcularImposto();
        func.MostrarDados();

        Console.Write("\nDigite a porcentagem de aumento: ");
        double aumento = double.Parse(Console.ReadLine());

        func.AumentarSalario(aumento);
        Console.WriteLine("\nApós aumento:");
        func.MostrarDados();

        Console.ReadKey();
    }
}