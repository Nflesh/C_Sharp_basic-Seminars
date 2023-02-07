

int SummaryOfNumbers(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += (num % 10);
        num /= 10;
    }    
    return sum;
}

int number;

Console.WriteLine("Введите число:");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Итоговая сумма:" + SummaryOfNumbers(number));





