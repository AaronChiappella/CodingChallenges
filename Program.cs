using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el script que desea ejecutar:");
        Console.WriteLine("1: Concatenación Alternada");
        Console.WriteLine("2: Es palindromo");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                C1 c1 = new C1();
                string result = c1.ConcatenacionAlternada("abc", "123");
                Console.WriteLine("Resultado final: " + result);
                break;
            case "2":
                C2 c2 = new C2();
                string word = "neuquen";
                bool resultC2 = c2.esPalindromo(word);
                if(resultC2)
                {
                    Console.WriteLine(word + " es palindromo");
                } else {
                    Console.WriteLine(word + " no es palindromo");
                };
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
