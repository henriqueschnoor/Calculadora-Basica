using System;

class Calculadora
{
    static void Main(string[] args)
    {
        double x, y;
        string operacao;

        Console.WriteLine("Bem vindo á calculadora de Henrique");

        Console.Write("Digite o primeiro numero: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Qual operação a ser usada (+),(-),(*),(/): ");
        operacao = Console.ReadLine();

        Console.Write("Digite o segundo numero: ");
        y = Convert.ToDouble(Console.ReadLine());

        switch (operacao)
        {
            case "+":
                Console.WriteLine("Resultado: " + (x + y));
                break;
            case "-":
                Console.WriteLine("Resultado: " + (y - x));
                break;
            case "*":
                if (x < 0) {
                    Console.WriteLine("Não podemos multiplicar por zero que será 0!!");
                } else {
                    Console.WriteLine("Resultado: " + (x / y));
                }
                break;
            case "/":
                if (x > 0)
                {
                    Console.WriteLine("Não podemos multiplicar por zero!!");
                }
                else {
                    Console.WriteLine("Resultado: " + (x / y));
                }
                break;

        }
        Console.WriteLine("Obrigado por usar minha Calculadora Basica");
    }
}
