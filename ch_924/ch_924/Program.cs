using System;

namespace ch_924
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Read();

            // 1. 提示使用者輸入身高(公分)
            Console.Write("請輸入身高 (公分): ");
            string heightInput = Console.ReadLine();
            double height = Convert.ToDouble(heightInput); // 將輸入轉為 double 型態

            // 2. 提示使用者輸入體重(公斤)
            Console.Write("請輸入體重 (公斤): ");
            string weightInput = Console.ReadLine();
            double weight = Convert.ToDouble(weightInput);

            // 3. 將身高(公分)轉換成公尺
            double heightMeter = height / 100;

            // 4. 計算 BMI
            double bmi = weight / (heightMeter * heightMeter);

            // 5. 顯示結果
            Console.WriteLine("您的 BMI 值為: " + bmi.ToString("0.00"));

            // 6. 判斷 BMI 分類
            if (bmi < 18.5)
            {
                Console.WriteLine("體重過輕");
            }
            else if (bmi >= 18.5 && bmi < 24)
            {
                Console.WriteLine("正常範圍");
            }
            else if (bmi >= 24 && bmi < 27)
            {
                Console.WriteLine("過重");
            }
            else
            {
                Console.WriteLine("肥胖");
            }

            // 7. 結束程式前等待使用者按下任意鍵
            Console.WriteLine("請按任意鍵結束程式...");
            Console.ReadKey();
        }
    }
}