using System.Globalization;

namespace HAConsApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            for (int i = 1; i <= 100; i++)
            {
                string result = i.ToString(CultureInfo.InvariantCulture);
                if (i % 3 == 0)
                {
                    result = "Fizz";
                    if (i % 5 == 0) result = "FizzBuzz";
                }
                else if (i % 5 == 0) result = "Buzz";
                Console.WriteLine(result);
            }
            Console.WriteLine("/////////////////////////////");

            //Задание 2
            Console.Write("Число: ");
            double num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Процент: ");
            double percent = Convert.ToInt32(Console.ReadLine());

            Console.Write("Результат: ");

            double res = (num / 100) * percent;
            Console.WriteLine(res);
            Console.WriteLine("/////////////////////////////");

            //Задание 3
            Console.Write("Число 1: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 2: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 3: ");
            double num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 4: ");
            double num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат: " + num1 + num2 + num3 + num4);
            Console.WriteLine("/////////////////////////////");

            //Задание 4
            Console.WriteLine("Введите шестизначное число: ");
            string num41 = Console.ReadLine();

            int num411 = Convert.ToInt32(num41);
            if (num411 > 999999 || num411 < 100000)
                Console.WriteLine("Ошибка ввода! Число не шестизначное!");

            Console.WriteLine("Какие цифры заменить? Указывать от 1 до 6:");
            int swapNum1 = Convert.ToInt32(Console.ReadLine());
            int swapNum2 = Convert.ToInt32(Console.ReadLine());

            char[] numStrArr = num41.ToCharArray();
            char temp1 = numStrArr[swapNum1 - 1];
            char temp2 = numStrArr[swapNum2 - 1];

            numStrArr[swapNum1 - 1] = temp2;
            numStrArr[swapNum2 - 1] = temp1;

            Console.WriteLine(numStrArr);

            Console.ReadLine();
            Console.WriteLine("/////////////////////////////");

            //Задание 5
            String date;
            Console.WriteLine("Введите дату в формате ГГГГ:ММ:ДД -> ");
            date = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(date);
            //Как вывести название времени года из введенной даты?
            Console.WriteLine(dt.ToString("dddd"));

            Console.WriteLine("/////////////////////////////");

            //Задание 6
            Console.Write("Введите температуру в градусах Цельсия: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("Температура по Фаренгейту: {0}", fahrenheit);

            Console.WriteLine("/////////////////////////////");

            //Задание 7
            Console.WriteLine("Укажите диапазон чисел от- и до-:");
            int num71 = Convert.ToInt32(Console.ReadLine());
            int num72 = Convert.ToInt32(Console.ReadLine());

            if (num71 > num72)
            {
                int temp;
                temp = num71;
                num71 = num72;
                num72 = temp;
            }

            for (int i = num71; i <= num72; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i); }
            }

            Console.ReadLine();
        }
    }
}