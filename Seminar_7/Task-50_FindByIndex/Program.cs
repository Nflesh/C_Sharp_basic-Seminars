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

void FindIndexInMatrix(int[,] arr, int lines, int columns)
{
    if((lines-1) < arr.GetLength(1) && (columns-1) < arr.GetLength(0))
    {
       Console.WriteLine("Число по выбранной позиции в массиве: " + arr[lines-1,columns-1]);
    }
    else
    {
        Console.WriteLine("Данные координаты в массиве отсутсвуют");
    }
}

int line = GetNumberFromConsole("Введите количество строк:");
int column = GetNumberFromConsole("Введите количество столбцов:");
int[,] array = GenerateRandomArray(line, column);
PrintArray(array);
int IDline = GetNumberFromConsole("Введите номер столбца:");
int IDcolumn = GetNumberFromConsole("Введите номер в строки:");
FindIndexInMatrix(array, IDcolumn, IDline);