// проверка на полиндром

void PullInArray(int[] arr)
{
    //Random rand = new Random();
    Console.WriteLine("Введите значения массива:");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine();
}

void ChekOnPolindrom(int[] arr)
{
    bool isPolindrom = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == arr[arr.Length-i-1])
        {
            isPolindrom = true;
        }
    }
    if(isPolindrom)
    {
        Console.WriteLine("Массив является полиндромом.");
    }
    else
    {
        Console.WriteLine("Массив не является полиндромом.");
    }
}

Console.WriteLine("Введите размер массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lengthArray];

PullInArray(array);
PrintArray(array);
ChekOnPolindrom(array);




