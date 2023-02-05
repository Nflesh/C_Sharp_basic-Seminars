void CubeTable(int numb)
{
    int temp;
    for (int i = 1; i <= numb; i++)
    {
        temp = i;
        temp = Convert.ToInt32(Math.Pow(temp,3));
        Console.Write(temp + " ");
    }
    
}




Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

CubeTable(number);
