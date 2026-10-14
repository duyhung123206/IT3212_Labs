using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập điểm (0 - 10): ");
        double diem;
        if (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
        {
            Console.WriteLine("Điểm phải thuộc [0, 10].");
        }
        else if (diem >= 9) Console.WriteLine("Xuất sắc");
        else if (diem >= 8) Console.WriteLine("Giỏi");
        else if (diem >= 6.5) Console.WriteLine("Khá");
        else if (diem >= 5) Console.WriteLine("Trung bình");
        else Console.WriteLine("Yếu");
    }
}