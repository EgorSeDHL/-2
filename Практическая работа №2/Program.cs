int a = 1;
while (1 <= a && a <= 4)
{
    Console.WriteLine("Выберите программу, которую хотите запустить");
    Console.WriteLine("1. Угадай число от 1 до 100");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Закрыть программу");
    Console.Write("Введите номер: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
    {
        first();
    }
    else if (a == 2)
    {
        second();
    }
    else if (a == 3)
    {
        third();
    }
    else if (a == 4)
    {
        break;
    }
    else
    {
        Console.WriteLine("вы ввели неверное число");
        a = 1;
    }
}

static void Main(string[] args)
{
    Console.WriteLine("Hello, World!");
}
static void first()
{
    Console.WriteLine("Угадайте число от 0 до ста");

    Random ram = new Random();
    int number = ram.Next(0, 100);

    int input = 0;
    while (true)
    {
        Console.WriteLine("Введите число");
        input = Convert.ToInt32(Console.ReadLine());

        if (number > input)
            Console.WriteLine("Нужно больше");

        else if (number < input)
            Console.WriteLine("Нужно меньше");

        else
        {
            Console.WriteLine("Вы угадали!");
            break;
        }
    }
}
static void second()
{
    int[,] matrica = new int[90, 90];

    for (int vertical = 1; vertical < 10; vertical++)
        for (int horizontal = 1; horizontal < 10; horizontal++)
            matrica[vertical, horizontal] = vertical * horizontal;

    for (int vertical = 1; vertical < 10; vertical++)
    {
        Console.WriteLine();
        for (int horizontal = 1; horizontal < 10; horizontal++)
            Console.Write("{0,3}", matrica[vertical, horizontal]);
        Console.WriteLine("");
    }

}
static void third()
{
    Console.Write("Введите число: ");
    int chislo = Convert.ToInt32(Console.ReadLine());
    for (int check = 1; check < (chislo + 1); check++)
    {
        if (chislo % check == 0)
        {
            Console.WriteLine(check);
        }
    }
}

