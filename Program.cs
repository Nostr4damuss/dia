using System;
using System.Data;    

DateTime date = new(2022, 10, 26);

int position = 1;

Console.WriteLine(date);
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        position++;
    }
    if (key.Key == ConsoleKey.LeftArrow)
    {
        date = date.AddDays(-1);
        Console.WriteLine(date);
    }
    if (key.Key == ConsoleKey.RightArrow)
    {
        date = date.AddDays(+1);
        Console.WriteLine(date);
    }
    if (date.Day == 27)
    {
        Console.WriteLine(date);
        Console.Clear();
        Console.WriteLine(date);
        pervoye();
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("    Прийти на день рождения Миши");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("    Описание: Подарить Мише подарок и вкусно покушать");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("    Подарить девушке цветы");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("    Описание: Купить букет роз и подарить их своей девушке");
            }
        }
    }
    if (date.Day == 28)
    {
        Console.WriteLine(date);
        Console.Clear();
        Console.WriteLine(date);
        vtoroye();
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("    Провести уборку в квартире");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("    Описание: Постирать белье, вымыть полы и протереть пыль");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("    Посмотреть любимый сериал");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("    Описание: Найти пульт и включить телевизор");
            }
        }
    }
    if (date.Day == 29)
    {
        Console.WriteLine(date);
        Console.Clear();
        Console.WriteLine(date);
        tretye();
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("    Приготовить маме чай");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("    Описание: Вскипятить чайник, налить воду в кружку и добавить чайный пакетик");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("    Покормить кота");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("    Описание: Открыть пачку Whiskas и насыпать в кошачью миску");
            }
        }
    }
    Console.SetCursorPosition(0, position);
    Console.WriteLine("=>");
}

static void pervoye()
{
    Console.WriteLine("    1. Прийти на день рождения Миши");
    Console.WriteLine("    2. Подарить девушке цветы");
}

static void vtoroye()
{
    Console.WriteLine("    1. Провести уборку в квартире");
    Console.WriteLine("    2. Посмотреть любимый сериал");
}

static void tretye()
{
    Console.WriteLine("    1. Приготовить маме чай");
    Console.WriteLine("    2. Покормить кота");
}