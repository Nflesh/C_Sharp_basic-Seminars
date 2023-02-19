int GetSize(string text)
{
    Console.WriteLine(text);    
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateRandomArray(int lines, int columns )
{
    double[,] arr = new double[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.NextDouble()*100;
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,8}", Math.Round(arr[i,j], 2));
        }
        Console.WriteLine();
    }
}

int line = GetSize("Введите количество строк:");
int column = GetSize("Введите количество столбцов:");
double[,] array = GenerateRandomArray(line, column);
PrintArray(array);