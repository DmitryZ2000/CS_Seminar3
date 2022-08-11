void PowerN(int number)
{
    int index = 1;
    while(index <= number)
    {
        Console.Write($"{index*index} ");
        index++;
    }
}

Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
PowerN(num);