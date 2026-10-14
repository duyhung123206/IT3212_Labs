using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử n = ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) return;

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            int.TryParse(Console.ReadLine(), out arr[i]);
        }

        int tong = arr.Sum();
        double trungBinh = (double)tong / n;
        int max = arr.Max();
        int min = arr.Min();
        int soChan = arr.Count(x => x % 2 == 0);

        Console.WriteLine("\n--- KẾT QUẢ THỐNG KÊ ---");
        Console.WriteLine("Tổng: " + tong);
        Console.WriteLine("Trung bình: " + trungBinh);
        Console.WriteLine("Số lớn nhất: " + max);
        Console.WriteLine("Số nhỏ nhất: " + min);
        Console.WriteLine("Số lượng số chẵn: " + soChan);
    }
}