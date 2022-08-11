double Distance(double x1, double y1, double x2, double y2)
{
    double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    return dist;
}

double mydist = Distance(2,40,3,4);
Console.WriteLine(mydist);