using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tablas de multiplicar del 1 al 10:");

        // Bucle for externo para los números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nTabla del {i}:");

            // Bucle for interno para multiplicar el número actual
            for (int j = 1; j <= 10; j++)
            {
                int resultado = i * j; // Calcular el resultado de la multiplicación
                Console.WriteLine($"{i} x {j} = {resultado}"); // Imprimir el resultado
            }
        }

        // Esperar a que el usuario presione una tecla
        Console.WriteLine("\nPresiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
}