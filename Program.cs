using System;

class Program
{
    public static void Main(string[] args)
    {

        string? texto1, texto2, texto3, texto4, auxiliar;

        Console.WriteLine("Aplicativo Console para Inverter a ordem dos textos digitados.\n");

        Console.Write("Digite o texto 1: ");
        texto1 = Console.ReadLine();

        Console.Write("Digite o texto 2: ");
        texto2 = Console.ReadLine();

        Console.Write("Digite o texto 3: ");
        texto3 = Console.ReadLine();

        Console.Write("Digite o texto 4: ");
        texto4 = Console.ReadLine();

        //Mecanismo pra inverter os textos
        auxiliar = texto1;
        texto1 = texto4;
        texto4 = auxiliar;
        auxiliar = texto2;
        texto2 = texto3;
        texto3 = auxiliar;

        Console.WriteLine();
        Console.WriteLine("Textos inseridos na ordem inversa\n");
        Console.WriteLine(texto1);
        Console.WriteLine(texto2);
        Console.WriteLine(texto3);
        Console.WriteLine(texto4);
        Console.WriteLine("\nPressione enter para finalizar! ");
        Console.ReadKey();
    }
}