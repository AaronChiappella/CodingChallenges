using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el script que desea ejecutar:");
        Console.WriteLine("1: Concatenación Alternada");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Solution solution = new Solution();
                string result = solution.ConcatenacionAlternada("abc", "123");
                Console.WriteLine("Resultado final: " + result);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
