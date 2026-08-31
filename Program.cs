using System;

namespace Actividad3//alexander topete rubio//
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Calculadora básica
            Console.WriteLine("=== EJERCICIO 1: CALCULADORA BÁSICA ===");
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
            
            if (num2 != 0)
                Console.WriteLine($"División: {num1} / {num2} = {num1 / num2:F2}");
            else
                Console.WriteLine("División: No se puede dividir entre cero");

            // Ejercicio 2: Rectángulo con color
            Console.WriteLine("\n=== EJERCICIO 2: RECTÁNGULO ===");
            Console.Write("Ingrese el color del rectángulo: ");
            string color = Console.ReadLine();
            Console.Write("Ingrese la base del rectángulo: ");
            double baseRect = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del rectángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double perimetro = 2 * (baseRect + altura);
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Base: {baseRect}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Perímetro: {perimetro}");

            // Ejercicio 3: Promedio de calificaciones
            Console.WriteLine("\n=== EJERCICIO 3: PROMEDIO DE CALIFICACIONES ===");
            double suma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese la calificación {i} (con 2 decimales): ");
                suma += Convert.ToDouble(Console.ReadLine());
            }
            double promedio = suma / 5;
            Console.WriteLine($"Promedio: {promedio:F2}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}