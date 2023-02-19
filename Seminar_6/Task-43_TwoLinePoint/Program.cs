double GetCoefficient(string text)
{
    Console.WriteLine(text);    
    return Convert.ToDouble(Console.ReadLine());
}

void PrintCoefficient(double b1,double b2,double k1,double k2)
{
    Console.WriteLine("Коэффициенты равны: \n"
                + "b1 = " + b1 + " \n"
                + "b2 = " + b2 + " \n"
                + "k1 = " + k1 + " \n"
                + "k2 = " + k2 + " \n");
}

void FindPoint(double b1,double b2,double k1,double k2)
{
    if(k1 != k2)
    {
        double x, y1, y2;
        x = (-b1+b2)/(k1-k2);
        y1 = k1 * x +b1;
        y2 = k2 * x +b2;
        Console.WriteLine("Координаты точки пересечения" + y1 + ", " + x + ", " + y2);
    }
    else
    {
        Console.WriteLine("Т.к. к1 и к2 равны, то прямые совпадают или параллельны");
    }
}

double B1, B2, K1, K2;

B1 = GetCoefficient("Введите коэффициент b1:");
B2 = GetCoefficient("Введите коэффициент b2:");
K1 = GetCoefficient("Введите коэффициент k1:");
K2 = GetCoefficient("Введите коэффициент k2:");
PrintCoefficient(B1,B2,K1,K2);
FindPoint(B1,B2,K1,K2);
