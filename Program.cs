

bool exit = false;

while (!exit)
{
    Console.WriteLine("");
    Console.WriteLine("Какую операцию вы хотите выполнить?");
    Console.WriteLine("1 Сложение");
    Console.WriteLine("2 Вычитание");
    Console.WriteLine("3 Деление");
    Console.WriteLine("4 Умножение");
    Console.WriteLine("5 Факториал");
    Console.WriteLine("6 Найти процент от числа");
    Console.WriteLine("7 Найти квадратный корень из числа");
    Console.WriteLine("8 Возвести число в степень N");
    Console.WriteLine("9 Выйти из калькулятора");

    int v = Convert.ToInt32(Console.ReadLine());
    int r = 0;
    string t = "";
    int q1 = 0;
    int q2 = 0;
    int m = 0;
    int s = 0;
    int l = 0;
    

    if (v >= 1 && v <= 4)
    {
        Console.Write("Введите число 1: ");
        q1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число 2: ");
        q2 = Convert.ToInt32(Console.ReadLine());
    }
    else if (v >= 5 && v <= 7)
    {
        Console.Write("Введите число: ");
        m = Convert.ToInt32(Console.ReadLine());
    }
    else if (v == 8)
    {
        Console.Write("Введите число: ");
        s = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите N: ");
        l = Convert.ToInt32(Console.ReadLine());
    }

    if (v == 1)
    {
        r = q1 + q2;
        t = "сложения";
    }
    else if (v == 2)
    {
        r = q1 - q2;
        t = "вычитания";
    }
    else if (v == 3)
    {
        if (q2 != 0)
        {
            r = q1 / q2;
            t = "деления";
        }
        else
        {
            Console.WriteLine("Ошибка: нельзя делить на ноль.");
            continue;
        }
    }
    else if (v == 4)
    {
        r = q1 * q2;
        t = "умножения";
    }
    else if (v == 5)
    {
        r = Factorial(m);
        t = "факториала";
    }
    else if (v == 6)
    {
        r = m / 100;
        t = "1 процент от числа";
    }
    else if (v == 7)
    {
        if (m >= 0)
        {
            r = (int)Math.Sqrt(m);
            t = "квадратного корня из числа";
        }
        else
        {
            Console.WriteLine("Ошибка: нельзя извлекать квадратный корень из отрицательного числа.");
            continue;
        }
    }
    else if (v == 8)
    {
        r = (int)Math.Pow(s, l);
        t = "возвести число в степень";
    }
    else if (v == 9)
    {
        Console.WriteLine("Выход из программы.");
        exit = true;
        break;
    }
    else
    {
        Console.WriteLine("Ошибка: неверный выбор операции.");
        continue;
    }

    Console.WriteLine("Результат " + t + " = " + r);
}

static int Factorial(int m)
{
    if (m == 0)
        return 1;
    else
        return m * Factorial(m - 1);
}
