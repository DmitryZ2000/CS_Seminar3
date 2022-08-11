int FindQuarter(int x, int y)
{
    if (x>0 && y>0)
        return 1;
    else if (x<0 && y>0)
        return 2;
    else if (x<0 && y<0)
        return 3;
    else if (x>0 && y<0)
        return 2;
    return 0;
}

Console.WriteLine(FindQuarter(0,4));
Console.WriteLine(FindQuarter(1,4));
Console.WriteLine(FindQuarter(-2,4));
Console.WriteLine(FindQuarter(-3,-4));
Console.WriteLine(FindQuarter(2,-4));