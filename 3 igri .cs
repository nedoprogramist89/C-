using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите программу: ");
            Console.WriteLine("1. Игра \"Угадай число\"");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Random random = new Random();
                    int w = random.Next(1, 101);
                    int q;
                    Console.WriteLine("Добро пожаловать в игру \"Угадай число\"!");
                    Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать его.");
                    do
                    {
                        Console.Write("Введите вашу догадку: ");
                        q = int.Parse(Console.ReadLine());
                        if (q < w)
                            Console.WriteLine("Загаданное число больше.");
                        else if (q > w)
                            Console.WriteLine("Загаданное число меньше.");
                        else
                            Console.WriteLine("Поздравляю! Вы угадали число.");
                    } while (q != w);
                    Console.WriteLine("Спасибо за игру!");
                    break;
                case 2:
                    Console.WriteLine("Таблица умножения:");
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.Write((i * j).ToString().PadLeft(4));
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:

                    Console.Write("Введите число: ");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("Делители числа " + r + ":");
                    for (int i = 1; i <= r; i++)
                    {
                        if (r % i == 0)
                            Console.WriteLine(i);
                    }
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор программы.");
                    break;
            }
        }
    }

    
}