using System;

namespace ch_924
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        // 提示使用者輸入體重（公斤）
        Console.Write("請輸入體重（公斤）：");
        string weightInput = Console.ReadLine();
        double weight = Convert.ToDouble(weightInput);

        // 提示使用者輸入身高（公尺）
        Console.Write("請輸入身高（公尺）：");
        string heightInput = Console.ReadLine();
        double height = Convert.ToDouble(heightInput);

        // 計算 BMI：BMI = 體重 / (身高 * 身高)
        double bmi = weight / (height * height);

        // 顯示結果
        Console.WriteLine("您的 BMI 值為：" + bmi.ToString("0.00"));
    }
}
