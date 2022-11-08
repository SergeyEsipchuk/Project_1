using System.Runtime.InteropServices;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num_1;
            float num_2;
            int operation;
            do
            {
                Console.WriteLine("Выберете операцию из списка:");
                Console.WriteLine("1. Сложить два числа");
                Console.WriteLine("2. Вычесть первое число из второго");
                Console.WriteLine("3. Перемножить два числа");
                Console.WriteLine("4. Разделить первое число на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент из числа");
                Console.WriteLine("8. Найти факториал из числа");
                Console.WriteLine("9. Выйти из программы");
                Console.Write("Операция:");
                operation = Convert.ToInt32(Console.ReadLine());
                if (operation == 9)
                {
                    break;
                }                                                    
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Первое число:");
                        num_1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Второе число:");
                        num_2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ:");
                        Console.WriteLine( num_1 + num_2);
                        break;
                    case 2:
                        Console.WriteLine("Первое число:");
                        num_1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Второе число:");
                        num_2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ:");
                        Console.WriteLine( num_1 - num_2);
                        break;
                    case 3:
                        Console.WriteLine("Первое число:");
                        num_1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Второе число:");
                        num_2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ");
                        Console.WriteLine( num_1 * num_2);
                        break;
                    case 4:
                        Console.WriteLine("Первое число:");
                        num_1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Второе число:");
                        num_2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ");
                        Console.WriteLine(num_1 / num_2);
                        break;
                    case 8:
                        Console.WriteLine("Число:");
                        num_1 = Convert.ToInt32(Console.ReadLine());
                        {
                            int factorial1;
                            factorial1 = 1;
                            for (int i = 1; i <= num_1; i++)
                                factorial1 *= i;
                            Console.WriteLine("Факториал числа:" + factorial1);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Число:");
                        num_1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Второе число:");
                        Console.WriteLine("Ответ:" + num_1 / 100);
                        break;
                    case 5:
                        Console.WriteLine("Число:");
                        num_1 = Convert.ToInt32(Console.ReadLine());
                        float n;
                        float otvet;
                        Console.WriteLine("Введите степень");
                        n = Convert.ToInt32(Console.ReadLine());
                        float num_1_n;
                        num_1_n = 1;
                        for (int i = 0; i < n; i++)
                        {
                           otvet =  num_1_n *= num_1;
                        }
                        Console.WriteLine("{0} ^ {1} = {2}" , num_1, n, num_1_n);
                        break;
                    case 6:
                        Console.WriteLine("Число:");
                        num_1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ:" + Math.Sqrt(num_1));
                        break;
                }
            }
            while (true);
        }
    }
}