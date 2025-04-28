class Program
{ 
    static void Main()
   {
    int valor = 5;
        switch (valor)

        {
            case 1:
                Console.WriteLine("valor digitado foi 1");
                break;

            case 2:
                Console.WriteLine("valor digitado foi 2");
                break;


            default:
                Console.WriteLine("valor não encontrado");
                break;
        }
   }
}