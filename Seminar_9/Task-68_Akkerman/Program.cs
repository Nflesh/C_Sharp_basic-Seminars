int ReadFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumber(int number)
{
    Console.WriteLine(number);
}

int AkermanFunction(int first, int second)
{
  if (first == 0)
    return second + 1;
  else
    if ((first != 0) && (second == 0))
      return AkermanFunction(first - 1, 1);
    else
      return AkermanFunction(first - 1, AkermanFunction(first, second - 1));
}

int firstNumber = ReadFromConsole("Введите первое число: ");
int secondNumber = ReadFromConsole("Введите второе число: ");

PrintNumber(AkermanFunction(firstNumber, secondNumber));

