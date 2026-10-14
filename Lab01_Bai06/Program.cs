using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Giải phương trình bậc hai: ax^2 + bx + c = 0");
        Console.Write("Nhập a = ");
        if (!double.TryParse(Console.ReadLine(), out double a)) return;

        Console.Write("Nhập b = ");
        if (!double.TryParse(Console.ReadLine(), out double b)) return;

        Console.Write("Nhập c = ");
        if (!double.TryParse(Console.ReadLine(), out double c)) return;

        if (a == 0)
        {
            // Phương trình bậc nhất: bx + c = 0
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phương trình vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Phương trình có một nghiệm: x = {0:N2}", x);
            }
        }
        else
        {
            // Phương trình bậc hai: ax^2 + bx + c = 0
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm thực.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0:N2}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                Console.WriteLine("x1 = {0:N2}", x1);
                Console.WriteLine("x2 = {0:N2}", x2);
            }
        }
    }
}