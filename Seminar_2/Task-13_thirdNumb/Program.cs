// нахождение 3го числа

int number;
int thirdNumber;
//int checkNumberSize  = 0;

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

thirdNumber = number; // буферная переменная для красивого вывода в конце

if( thirdNumber / 100 > 0)
{
    while ( thirdNumber / 100 > 10)
    {
        thirdNumber /= 10;

    }
    
    thirdNumber %= 100; // для нахождения двухзначного остатка
    thirdNumber %= 10; // для нахождения 3й цифры  
}
else
{
    Console.WriteLine("Число двухзначное. 3я цифра отсутсвует");
}

Console.WriteLine($"3я цифра числа {number} = {thirdNumber}");
