void Quater(int number)
{
    if (number >= 1 && number <= 4)
        if (number == 1)
            Console.WriteLine("Это первая четверть и x > 0 и y > 0");
        else if (number == 2)
            Console.WriteLine("Это вторая четверть и x > 0 и y < 0");
        else if (number == 3)
            Console.WriteLine("Это третья четверть и x < 0 и y < 0");
        else if (number == 4)
            Console.WriteLine("Это четверть четверть и x > 0 и y < 0");
    else
        Console.WriteLine("Не верно введена номер четверти");

}

Quater(1);