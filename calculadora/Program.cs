class Program
{
    static void Main()
    {
        int opcao;
        double num1, num2, resultado;

        Console.WriteLine("Menu");
        Console.WriteLine("1 Soma:");
        Console.WriteLine("2 Subtração:");
        Console.WriteLine("3 Divisão:");
        Console.WriteLine("4 Multiplicação:");
        Console.WriteLine("5 Resto:");
        Console.WriteLine("Opção: ");
        opcao = int.Parse(Console.ReadLine());



        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite o primeiro numero:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                resultado = num1 + num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case 2:
                Console.WriteLine("Digite o primeiro numero:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                resultado = num1 - num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case 3:
                Console.WriteLine("Digite o primeiro numero:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                resultado = num1 / num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case 4:
                Console.WriteLine("Digite o primeiro numero:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                resultado = num1 * num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case 5:
                Console.WriteLine("Digite o dividendo:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o divisor:");
                num2 = double.Parse(Console.ReadLine());
                resultado = num1 % num2;
                Console.WriteLine($"Reultado: {resultado}");

                break;


            default:
                Console.WriteLine("Valor não encontrado");
                break;

        }
    }
}
