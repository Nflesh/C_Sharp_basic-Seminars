
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintText(string text)
{
    Console.WriteLine(text);
}

int[,] GenerateMatrix(int size)
{
    int[,] matr = new int[size, size];
    int n =0;
    int x0 = 0; //горизонталь начало
    int xn = size -1; //горизонталь конец
    int y0 = 0; //вертикаль начало
    int yn = size -1; //вертикаль конец

    while(n < size * size)
    {
        for(int x = x0; x <= xn; x++)
        {
            matr[y0,x] = ++n;  
        }
        
        y0++; // "обрезание" верхней строки
        
        for(int y = y0; y <= yn; y++)
        {
            matr[y,xn] = ++n;
        }

        xn--; // "обрезание" правого стролбца

        for(int x = xn; x >= x0; x--)
        {
            matr[yn,x] = ++n;
        }

        yn--; // "обрезание" нижней строки

        for(int y = yn; y >= y0; y--)
        {
            matr[y,x0] = ++n;
        }

        x0++; // "обрезание" левого стролбца
    } 
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "\t");
        }
        Console.WriteLine();
    }
    
}

int sizeOfMatrix =0;

sizeOfMatrix = GetNumberFromConsole("Введите количество строк:");
PrintText("Спиральная матрица:");
PrintMatrix(GenerateMatrix(sizeOfMatrix));


