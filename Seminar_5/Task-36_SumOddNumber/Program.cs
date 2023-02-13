int[] WriteRandomArray(int[] arr)
{
    Random rand = new Random();

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1,11);
    }
    return arr;
}


int FindSumOdd(int[] arr)
{
    int sumOddNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 != 0)
        {
            sumOddNumber += arr[i];
        }
    }
    return sumOddNumber;
}

void PrintText(string text)
{
    Console.WriteLine(text);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine();
}

PrintText("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

WriteRandomArray(array);
PrintText("Сгенерированный массив: ");
PrintArray(array);
PrintText($"Количество четных чисел: {FindSumOdd(array)}");


