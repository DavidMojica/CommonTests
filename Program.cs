using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            // Invertir una cadena
            Console.WriteLine(test.ReverseString("hello"));
            // Numero primo
            Console.WriteLine(test.EsPrimo(4));
            Console.WriteLine(test.EsPrimo(9));
            Console.WriteLine(test.EsPrimo(13));
            // Suma de pares en array
            Console.WriteLine(test.SumaDePares(new int[] { 2, 4, 3, 5, 7, 8, 9 }, 10));
            // Ordenar array de enteros
            Console.WriteLine(test.OrdenarArray(new int[] { 5, 3, 8, 4, 2 }));
            // Palindromo
            Console.WriteLine(test.EsPalindromo("radar"));
            Console.WriteLine(test.EsPalindromo("hola"));
            // Factorial
            Console.WriteLine(test.Factorial(5));
            // Fibonacci
            Console.WriteLine(test.Fibonacci(7));
            //Numero mas grande en un array
            Console.WriteLine(test.Mayor(new int[] { 3, 5, 7, 2, 8, -1, 4 }));
            // Invertir array
            Console.WriteLine(test.InvertirArray(new int[] { 1, 2, 3, 4, 5 }));
            // Contar vocales
            Console.WriteLine(test.ContarVocales("Hello World"));
        }
    }
}
