using System;

class Programa
{
    public static void Main()
    {
        try
        {
            Console.Write("Digite o número a ser dividido: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o divisor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1/num2;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: Não é possível dividir por zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, digite apenas números.");
        }
        finally
        {
            Console.WriteLine("Fim da operação.");
        }
    }
}
