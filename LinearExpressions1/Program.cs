using System;
class Program
{
    static void Main()
    {
        double a, b, c, d;
        Console.WriteLine("Enter a value for variables:");
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        d = double.Parse(Console.ReadLine());

        Console.WriteLine("\nx = (a+2*b-c+d)/(c*d) + (a+b)/(c-d) - a^2/b^2 \ny = (5*(a+b)*(c-d))/(1/2*c) + d^2*(a^2-b^2)/(b-a) \nz = ((x^2-2*x)^3-4*(x^4+1))*(1-b)/(5*a+3*b)\nr = (1/2*a+3/4*b-7/5)/(3*c+1) + (1/(a-c))");
        double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
        double y = (5 * (a + b) * (c - d)) / (1.0 / 2 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
        double z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
        double r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);
        Console.WriteLine("\nx = {0}\ny = {1}\nz = {2}\nr = {3}", x, y, z, r);
    }
}