class Progam
{

    static void Main()
    {


        Console.WriteLine("Digite uma letra de A até E");
        char informacao = Convert.ToChar(Console.ReadLine());

        switch (informacao)
        {
            case 'A':
                Console.WriteLine("Excelente");
                break;
            case 'B':
                Console.WriteLine("Bom");
                break;
            case 'C':
                Console.WriteLine("Regular");
                break;
            case 'D':
                Console.WriteLine("Ruim");
                break;
            case 'E':
                Console.WriteLine("Péssimo");
                break;

            default:
                Console.WriteLine("Essa letra não foi encontrada");
                break;

        }



    }

}



