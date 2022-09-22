namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Write("1 - Сложение \r\n2 - Вычитание \r\n3 - Умножение \r\n4 - Деление \r\n5 - Возведение в степень \r\n6 - Нахождение корня \r\n7 - Нахождение 1% \r\n8 - Нахождение факториала \r\n9 - Выход \r\n");


            int Number = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (Number == 1)
                {
                    Console.WriteLine("Выбрана операция сложения");
                    Console.WriteLine("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = (num1 + num2);
                    Console.WriteLine("Результат операции: " + num3);
                    goto start;
                }
                else if (Number == 2)
                {
                    Console.WriteLine("Выбрана операция вычитания");
                    Console.WriteLine("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = (num1 - num2);
                    Console.WriteLine("Результат операции: " + num3);
                    goto start;
                }
                else if (Number == 3)
                {
                    Console.WriteLine("Выбрана операция умножения");
                    Console.WriteLine("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = (num1 * num2);
                    Console.WriteLine("Результат операции: " + num3);
                    goto start;
                }
                else if (Number == 4)
                {
                    Console.WriteLine("Выбрана операция деления");
                    Console.WriteLine("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = (num1 / num2);
                    Console.WriteLine("Результат операции: " + num3);
                    goto start;
                }
                else if (Number == 5)
                {
                    Console.WriteLine("Выбрана операция возведения в степень");
                    Console.WriteLine("Введите число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции: " + Math.Pow(num1, num2));
                    goto start;
                }
                else if (Number == 6)
                {
                    Console.WriteLine("Выбрана операция нахождения квадратного корня");
                    double num2;
                    num2 = 0.5;
                    Console.WriteLine("Введите число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции: " + Math.Pow(num1, num2));
                    goto start;
                }
                else if (Number == 7)
                {
                    Console.WriteLine("Выбрана операция нахождения 1% от числа");
                    Console.WriteLine("Введите число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    double num2 = (num1 / 100);
                    Console.WriteLine("Результат операции: " + num2);
                    goto start;
                }
                else if (Number == 8)
                {
                    Console.WriteLine("Выбрана операция нахождения факториала числа");
                    Console.WriteLine("Введите число: ");
                    int fact = Convert.ToInt32(Console.ReadLine());
                    for (int i = fact - 1; i >= 1; i--)
                    {
                        fact = fact * i;
                    }
                    Console.WriteLine("Результат операции: " + fact);
                    goto start;
                }
            } while (Number != 9);
        }
    }
}