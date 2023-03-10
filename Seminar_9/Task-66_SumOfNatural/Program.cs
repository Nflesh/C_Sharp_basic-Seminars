int ReadFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNaturalNumber(int first, int last)
{
    if(first <= last)
    {
        Console.Write(first + ", ");
        first++;
    
        PrintNaturalNumber(first, last);
    }
}

int firstNumber = ReadFromConsole("Введите первоначальное число:");
int endNumber = ReadFromConsole("Введите конечное число:");

if(firstNumber < endNumber)
{
    PrintNaturalNumber(firstNumber, endNumber);
}
else
{
    Console.WriteLine("Введены неправельные значения");
}



