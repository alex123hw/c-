using System;

class Program{

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.Cuadrado 2.Círculo 3.Rombo 4.Trapecio 5.Triángulo 6.Salir");
            string fig = Console.ReadLine();
            if (fig == "6") break;

            double a = 0, p = 0;
            string nom = "";

            switch (fig)
            {
                case "1":
                    Console.Write("Lado: "); double l = double.Parse(Console.ReadLine());
                    a = l * l; p = 4 * l; nom = "Cuadrado"; break;
                case "2":
                    Console.Write("Radio: "); double r = double.Parse(Console.ReadLine());
                    a = Math.PI * r * r; p = 2 * Math.PI * r; nom = "Círculo"; break;
                case "3":
                    Console.Write("Dmayor: "); double dM = double.Parse(Console.ReadLine());
                    Console.Write("Dmenor: "); double dm = double.Parse(Console.ReadLine());
                    Console.Write("Lado: "); double lr = double.Parse(Console.ReadLine());
                    a = (dM * dm) / 2; p = 4 * lr; nom = "Rombo"; break;
                case "4":
                    Console.Write("BMayor: "); double bM = double.Parse(Console.ReadLine());
                    Console.Write("BMenor: "); double bm = double.Parse(Console.ReadLine());
                    Console.Write("LadoIzq: "); double li = double.Parse(Console.ReadLine());
                    Console.Write("LadoDer: "); double ld = double.Parse(Console.ReadLine());
                    Console.Write("Altura: "); double h = double.Parse(Console.ReadLine());
                    a = ((bM + bm) * h) / 2; p = bM + bm + li + ld; nom = "Trapecio"; break;
                case "5":
                    Console.Write("Lado A: "); double A = double.Parse(Console.ReadLine());
                    Console.Write("Lado B: "); double B = double.Parse(Console.ReadLine());
                    Console.Write("Lado C: "); double C = double.Parse(Console.ReadLine());
                    p = A + B + C; double s = p / 2;
                    a = Math.Sqrt(s * (s - A) * (s - B) * (s - C)); nom = "Triángulo"; break;
                default: Console.WriteLine("Opción inválida"); Console.ReadKey(); continue;
            }

            Console.WriteLine("1.Área  2.Perímetro  3.Ambos");
            string op = Console.ReadLine();
            Console.WriteLine($"\n{nom}:");
            if (op == "1" || op == "3") Console.WriteLine($"Área = {a:F2}");
            if (op == "2" || op == "3") Console.WriteLine($"Perímetro = {p:F2}");
            Console.ReadKey();
        }
    }
}