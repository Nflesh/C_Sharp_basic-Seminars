int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);    
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateRandomArray(int lines, int columns )
{
    int[,] arr = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(10,100);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,8}",arr[i,j]);
        }
        Console.WriteLine();
    }
}

void FindAverageSum(int[,] arr)
{
    double[] arrayOfSum = new double[arr.GetLength(1)]; 
    int[] arraySum = new int[arr.GetLength(1)];
    int[] arrayCounter = new int[arr.GetLength(1)];
    int counter = 0;
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum+= arr[i,j];
            counter++;
        }
        arrayOfSum[j] = (double) sum / counter;
        arraySum[j] = sum;
        arrayCounter[j] = counter;
        sum = 0;
        counter = 0;
    }
   
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write("{0,8}", Math.Round(arrayOfSum[j], 2));
    }
    Console.WriteLine();
    
    Console.WriteLine("Cумма стобцов: " + "{0,8}", string.Join(" | ",arraySum));
    Console.WriteLine("Кол-во эл-ов суммы: " + "{0,8}", string.Join(" | ",arrayCounter));
}

int line = GetNumberFromConsole("Введите количество строк:");
int column = GetNumberFromConsole("Введите количество столбцов:");
int[,] array = GenerateRandomArray(line, column);
PrintArray(array);
FindAverageSum(array);
