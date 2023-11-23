using System;
class Program
{
    static void Main()
    {
        double m, n, a, b, x;
        Console.WriteLine("Enter a value for variables:");
        Console.Write("m = ");
        m = double.Parse(Console.ReadLine());
        Console.Write("n = ");
        n = double.Parse(Console.ReadLine());
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("\nz1 = ((m-1)*√m-(n-1)*√n)/(√(m^3*n)+n*m+m^2-m)\nz2 = (√m-√n)/m\ny = 2,4*|(x^2+b)/a|+(a-b)*sin^2(a-b)+10^-2*(x-b)");
        double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
        double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
        Console.WriteLine("\nz1 = {0}\nz2 = {1}\ny = {2}", z1, z2, y);
    }
}