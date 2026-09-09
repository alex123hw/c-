using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Nombre: "); string nombre = Console.ReadLine();
        Console.Write("Matrícula: "); string mat = Console.ReadLine();
        Console.Write("Plantel: "); string plantel = Console.ReadLine();
        Console.Write("Semestre: "); string sem = Console.ReadLine();

        double[] calif = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Calif {i+1}: ");
            calif[i] = double.Parse(Console.ReadLine());
        }

        double prom = 0;
        foreach (double c in calif) prom += c;
        prom /= 5;

        Console.WriteLine($"\nNombre: {nombre}\nMatrícula: {mat}\nPlantel: {plantel}\nSemestre: {sem}");
        Console.Write("Calificaciones: " + string.Join(", ", Array.ConvertAll(calif, x => x.ToString("F2"))));
        Console.WriteLine($"\nPromedio: {prom:F2}");
        Console.ReadKey();
    }
}