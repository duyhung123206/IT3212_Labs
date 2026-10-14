using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int chon;
        do
        {
            Console.WriteLine("\n--- MENU VẼ HÌNH ---");
            Console.WriteLine("1. Tam giác vuông đặc");
            Console.WriteLine("2. Tam giác vuông rỗng");
            Console.WriteLine("3. Hình vuông rỗng");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            int.TryParse(Console.ReadLine(), out chon);

            switch (chon)
            {
                case 1:
                    Console.Write("Nhập chiều cao h = ");
                    int.TryParse(Console.ReadLine(), out int h1);
                    for (int i = 1; i <= h1; i++)
                    {
                        Console.WriteLine(new string('*', i));
                    }
                    break;

                case 2:
                    Console.Write("Nhập chiều cao h = ");
                    int.TryParse(Console.ReadLine(), out int h2);
                    for (int i = 1; i <= h2; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (j == 1 || j == i || i == h2) Console.Write("*");
                            else Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.Write("Nhập cạnh n = ");
                    int.TryParse(Console.ReadLine(), out int n);
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == n) Console.Write("* ");
                            else Console.Write("  ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        } while (chon != 0);
    }
}