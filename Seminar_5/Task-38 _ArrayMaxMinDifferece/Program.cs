
int[] array = new int[10];
int difference;


// Создание массива и его заполнение случайными числами
void RandomizeArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1, 101);
    }
}


// Вывод массива в консоль
void PrintArray(int[] arr)
{
    Console.WriteLine("Массив чисел:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Поиск максимального и минимального элементов массива

int FindMaxMinDeference(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    int diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
        
    }
    Console.WriteLine("Max: " + max);
    Console.WriteLine("Min: " + min);
    diff = max - min;
    return diff;
}


RandomizeArray(array);
PrintArray(array);
difference = FindMaxMinDeference(array);

// Вывод результата в консоль
Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);

Console.ReadLine();

