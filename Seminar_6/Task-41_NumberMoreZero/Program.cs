/* задача 41 применять 
var array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
задача 43 y=k1*x+b1 y=k2*x+b2  - система уравнений k1*x+b1 = k2*x+b2 
использовать функции
*/
int[] GetArray(string text)
{
    Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return array;
}

int CounterPositivNumber(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 0)
        {
            counter++;
        }
    }
    
    return counter;
}

void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(" | ", arr));
}

int[] array = GetArray("Введите массив:");

PrintArray(array);
Console.WriteLine($"Число положительных чисел в массиве {CounterPositivNumber(array)}");


