void PrintText(string text)
{
    Console.WriteLine(text);
}

int GetIntNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GetTripleDimensionArray(int sizex, int sizey, int sizez)
{
    int[,,] arrTriple = new int[sizex, sizey, sizez];
    Random rand = new Random();

    for (int x = 0; x < arrTriple.GetLength(0); x++)
    {
        for (int y = 0; y < arrTriple.GetLength(1); y++)
        {
            for (int z = 0; z < arrTriple.GetLength(2); z++)
            {
                arrTriple[x,y,z] = rand.Next(1,25);
            }
        }
    }
    return arrTriple;
}

void PrintMatrix(int[,,] arrTriple)
{
    for (int x = 0; x < arrTriple.GetLength(0); x++)
    {
        for (int y = 0; y < arrTriple.GetLength(1); y++)
        {
            for (int z = 0; z < arrTriple.GetLength(2); z++)
            {
                Console.Write($"{arrTriple[x,y,z]} \t ({x}, {y}, {z}) \t |  \t"); 
            }
            Console.WriteLine();
        }
        
    }
}

int sizeX,sizeY,sizeZ;

PrintText("Ввод размеров трехмерного массива");
sizeX = GetIntNumberFromConsole("Введите размерность Х");
sizeY = GetIntNumberFromConsole("Введите размерность Y");
sizeZ = GetIntNumberFromConsole("Введите размерность Z");
PrintText("Вывод трехмерного массива");
PrintMatrix(GetTripleDimensionArray(sizeX, sizeY, sizeZ));