
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintText(string text)
{
    Console.WriteLine(text);
}

int[,] GetMatrixFromConsole(int lines, int columns)
{
    int[,] matr = new int[lines, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine($"Введите элемент находящийся в {i + 1} строке, в {j + 1} столбце");
            matr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return matr;
}

int[,] GenerateRandomMatrix(int lines, int columns)
{
    int[,] matr = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(10, 100);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MinSumLine(int[,] matr)
{
    int minSum = int.MaxValue;
    int sum;
    int numberOfLine = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i,j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            numberOfLine = i;
        }
    }
    Console.WriteLine($"Минимальная сумма находится в строке {numberOfLine+1}  и равна {minSum}");
}


int lineOfMatrix = 0, columnOfMatrix = 0, inputMethod;
int[,] matrix = new int[lineOfMatrix, columnOfMatrix];

lineOfMatrix = GetNumberFromConsole("Введите количество строк:");
columnOfMatrix = GetNumberFromConsole("Введите количество стобцов не равное количеству строк:");
if (lineOfMatrix != columnOfMatrix)
{
    inputMethod = GetNumberFromConsole("1. Ручной ввод \n" +
                                   "2. Генерация из случайных чисел \n" +
                                   "Выберите способ ввода и введите его номер:");


    switch (inputMethod)
    {
        case 1:
            matrix = GetMatrixFromConsole(lineOfMatrix, columnOfMatrix);
            PrintText("Массив");
            PrintMatrix(matrix);
            break;
        case 2:
            matrix = GenerateRandomMatrix(lineOfMatrix, columnOfMatrix);
            PrintText("Массив");
            PrintMatrix(matrix);
            break;
        default:
            Console.WriteLine("Такого метода не существует");
            break;
    }

    PrintText("Отсортированная матрица:");
    MinSumLine(matrix);
}




