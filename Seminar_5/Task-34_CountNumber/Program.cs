int[] WriteRandomArray(int[] arr)
{
    Random rand = new Random();

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100,1000);
    }
    return arr;
}


int FindEvenNumber(int[] arr)
{
    int countEvenNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            countEvenNumber++;
        }
    }
    return countEvenNumber;
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
PrintText($"Количество четных чисел: {FindEvenNumber(array)}");


