void PutInArray(int[] arr)
{
    Random rand = new Random(); 
    for(int i = 0; i < arr.Length; i++) 
    {
	    arr[i] = rand.Next(1, 25); 
    }
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
	    Console.Write(arr[i]+ ", "); // вывод i-го элемента
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

PutInArray(array);
Console.WriteLine("Итоговый массив:");
PrintArray(array);



