namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("1 - Сложение \r\n2 - Вычитание \r\n3 - Умножение \r\n4 - Деление \r\n5 - Возведение в степень \r\n6 - Нахождение корня \r\n7 - Нахождение 1% \r\n8 - Нахождение факториала \r\n9 - Выход \r\n");

            do
            {
                Console.Write("Выберите операцию: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Выбрана операция сложения");
                    Console.WriteLine("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = (num1 + num2);
                    Console.WriteLine("Результат операции: " + num3);
                }
                else if (number == 2)
                {
                    Console.WriteLine("Выбрана операция вычитания");
                    Console.WriteLine("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = (num1 - num2);
                    Console.WriteLine("Результат операции: " + num3);
                }
                else if (number == 3)
                {
                    Console.WriteLine("Выбрана операция умножения");
                    Console.WriteLine("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = (num1 * num2);
                    Console.WriteLine("Результат операции: " + num3);
                }
                else if (number == 4)
                {
                    Console.WriteLine("Выбрана операция деления");
                    Console.WriteLine("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = (num1 / num2);
                    Console.WriteLine("Результат операции: " + num3);
                }
                else if (number == 5)
                {
                    Console.WriteLine("Выбрана операция возведения в степень");
                    Console.WriteLine("Введите число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции: " + Math.Pow(num1, num2));
                }
                else if (number == 6)
                {
                    Console.WriteLine("Выбрана операция нахождения квадратного корня");
                    double num2;
                    num2 = 0.5;
                    Console.WriteLine("Введите число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат операции: " + Math.Pow(num1, num2));
                }
                else if (number == 7)
                {
                    Console.WriteLine("Выбрана операция нахождения 1% от числа");
                    Console.WriteLine("Введите число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    double num2 = (num1 / 100);
                    Console.WriteLine("Результат операции: " + num2);
                }
                else if (number == 8)
                {
                    Console.WriteLine("Выбрана операция нахождения факториала числа");
                    Console.WriteLine("Введите число: ");
                    int fact = Convert.ToInt32(Console.ReadLine());
                    for (int i = fact - 1; i >= 1; i--)
                    {
                        fact = fact * i;
                    }
                    Console.WriteLine("Результат операции: " + fact);
                }
                else if (number == 9)
                {
                    Console.WriteLine("Программа завершена");
                    Environment.Exit(9);
                }
            } while (true);
        }
    }
}