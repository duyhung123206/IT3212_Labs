using System;

class Program
{
    static string DocSo(int n)
    {
        string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        if (n < 10) return chuSo[n];

        int chuc = n / 10;
        int donVi = n % 10;
        string kq = "";

        switch (chuc)
        {
            case 1: kq = "mười"; break;
            default: kq = chuSo[chuc] + " mươi"; break;
        }

        if (donVi == 1 && chuc > 1) kq += " mốt";
        else if (donVi == 5 && chuc > 0) kq += " lăm";
        else if (donVi > 0) kq += " " + chuSo[donVi];

        return kq;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên từ 0 đến 99: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0 && n <= 99)
        {
            Console.WriteLine("Cách đọc: " + DocSo(n));
        }
        else
        {
            Console.WriteLine("Số nhập vào không hợp lệ!");
        }
    }
}
