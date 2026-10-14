using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int chon;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Tổng 1..n");
            Console.WriteLine("2. Bảng cửu chương");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            int.TryParse(Console.ReadLine(), out chon);

            switch (chon)
            {
                case 1:
                    Console.Write("n = ");
                    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                    {
                        int tong = 0;
                        for (int i = 1; i <= n; i++) tong += i;
                        Console.WriteLine("Tổng = " + tong);
                    }
                    else
                    {
                        Console.WriteLine("Giá trị n không hợp lệ!");
                    }
                    break;

                case 2:
                    Console.WriteLine("Bảng cửu chương 7:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("7 x {0} = {1}", i, 7 * i);
                    }
                    break;

                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                    break;
            }
        } while (chon != 0);
    }
}
