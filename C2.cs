using System;

public class C2
{
    public bool esPalindromo(string word)
    {
        string auxiliar = "";
        string wordAux = word;
        
        int wordLength = word.Length;  

        for (int i = wordLength - 1; i >= 0; i--)
        {
            auxiliar += word[i];  
        }

        if (word == auxiliar)
        {
            return true;  // Si son iguales, es un palíndromo
        }
        else
        {
            return false;  // Si no son iguales, no es un palíndromo
        }
    }
}
