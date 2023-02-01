// Ввести цифру дня недели и сказать, это выходной или нет

string weekDay;

Console.Write("Введите цифру дня недели: ");
weekDay = Console.ReadLine();


switch(weekDay)
{
    case "1":
    case "2":
    case "3":
    case "4":
    case "5":
        Console.WriteLine($"{weekDay}й день недели - это будний день.");
        break;
    case "6":
    case "7":
        Console.WriteLine($"{weekDay}й день недели - это выходной день.");
        break;
    default:
        Console.WriteLine($"{weekDay}го дня недели не существует.");
        break;
}