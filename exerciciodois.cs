using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        int numeroDePalavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    
        Console.WriteLine($"A frase contém {numeroDePalavras} palavra(s).");
    }
}