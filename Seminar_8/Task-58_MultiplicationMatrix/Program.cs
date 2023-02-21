
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintText(string text)
{
    Console.WriteLine(text);
}

int[,] GetMatrixFromConsole(int lines, int columns, string text)
{
    int[,] matr = new int[lines, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine($"Введите элемент находящийся в {i + 1} строке, в {j + 1} столбце матрицы {text}");
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

int[,] MatrixMultiplication(int[,] matrA, int[,] matrB, int linesA, int columnB)
{

    int[,] multiMatrix = new int[linesA, columnB];
    
    for (int idLinesA = 0; idLinesA < matrA.GetLength(0); idLinesA++)
    {
        
        for (int idColumnB = 0; idColumnB < matrB.GetLength(1); idColumnB++) // матрица Перемножения
        {
            int summaryOfElements = 0;
            for (int idLinesB = 0; idLinesB < matrB.GetLength(0); idLinesB++)
            {
                
                    summaryOfElements += (matrA[idLinesA, idLinesB] * matrB[idLinesB, idColumnB]);
            }
            multiMatrix[idLinesA, idColumnB] = summaryOfElements;
        }
    }
    return multiMatrix;

}


int lineOfMatrixA = 0, columnOfMatrixA = 0, lineOfMatrixB = 0, columnOfMatrixB = 0, inputMethod;
int[,] matrixA = new int[lineOfMatrixA, columnOfMatrixA];
int[,] matrixB = new int[lineOfMatrixB, columnOfMatrixB];

lineOfMatrixA = GetNumberFromConsole("Введите количество строк матрицы A:");
columnOfMatrixA = GetNumberFromConsole("Введите количество стобцов матрицы A:");
lineOfMatrixB = GetNumberFromConsole("Введите количество строк матрицы B:");
columnOfMatrixB = GetNumberFromConsole("Введите количество стобцов матрицы B:");
if (columnOfMatrixA == lineOfMatrixB) 
{
    inputMethod = GetNumberFromConsole("1. Ручной ввод \n" +
                                   "2. Генерация из случайных чисел \n" +
                                   "Выберите способ ввода и введите ero номер:");


    switch (inputMethod)
    {
        case 1:
            matrixA = GetMatrixFromConsole(lineOfMatrixA, columnOfMatrixA, "A");            
            matrixB = GetMatrixFromConsole(lineOfMatrixB, columnOfMatrixB, "Б");
    
            PrintText("Массив A:");
            PrintMatrix(matrixA);
            PrintText("Массив B:");
            PrintMatrix(matrixB);
            break;
        case 2:
            matrixA = GenerateRandomMatrix(lineOfMatrixA, columnOfMatrixA);
            PrintText("Массив A:");
            PrintMatrix(matrixA);
            matrixB = GenerateRandomMatrix(lineOfMatrixB, columnOfMatrixB);
            PrintText("Массив B:");
            PrintMatrix(matrixB);
            break;
        default:
            Console.WriteLine("Такого метода не существует");
            break;
    }

    
    PrintText("Перемноженная матрица:");
    PrintMatrix(MatrixMultiplication(matrixA, matrixB, lineOfMatrixA, columnOfMatrixB));
}
else
{
    PrintText("Такие матрицы перемножить невозможно");
}







