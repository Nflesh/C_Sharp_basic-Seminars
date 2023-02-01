 // найти 3ю цифру числа

int number;
int secondNumber;

Console.Write("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

secondNumber = (number % 100 - number % 10) / 10 ;

Console.WriteLine($"2я цифра числа {number} = {secondNumber}");