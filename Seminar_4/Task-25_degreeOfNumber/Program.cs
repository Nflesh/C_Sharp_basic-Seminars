int Exponent(int number, int degree)
{
    int numberDegree = number;
    for(int i = 1; i < degree; i++ )
    {
        numberDegree *= number;
    }
    return numberDegree;
}



int numberA, numberB;
Console.WriteLine("Введите число:");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {numberA} в степени {numberB} = {Exponent(numberA,numberB)}");

