using System;
using System.Collections.Generic;

Console.WriteLine("Ingrese números separados por comas para verificar si son primos:");
string input = Console.ReadLine();

// Convertir la entrada en una lista de números
string[] numbers = input.Split(',');
List<int> primes = new List<int>();
List<int> nonPrimes = new List<int>();

foreach (string numStr in numbers)
{
    if (int.TryParse(numStr.Trim(), out int number))
    {
        if (IsPrime(number))
        {
            primes.Add(number);
        }
        else
        {
            nonPrimes.Add(number);
        }
    }
    else
    {
        Console.WriteLine($"'{numStr}' no es un número válido.");
    }
}

// Mostrar resultados
Console.WriteLine("Números primos: " + string.Join(", ", primes));
Console.WriteLine("Números no primos: " + string.Join(", ", nonPrimes));

// Método para verificar si un número es primo
bool IsPrime(int n)
{
    if (n <= 1)
        return false;
    if (n == 2)
        return true;
    if (n % 2 == 0)
        return false;

    for (int i = 3; i <= Math.Sqrt(n); i += 2)
    {
        if (n % i == 0)
            return false;
    }

    return true;
}
