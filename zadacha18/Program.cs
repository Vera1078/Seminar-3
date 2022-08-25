// Задача 18.  Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y)

System.Console.Write("Ведите номер четверти: ");
int Quarter = int.Parse(Console.ReadLine()!);

switch (Quarter)
{
    case 1:
    System.Console.WriteLine("В первой четверти x>0 и y>0 ");
    break;

     case 2:
    System.Console.WriteLine("Во второй четверти x<0 и y>0 ");
    break;

     case 3:
    System.Console.WriteLine("В третьей четверти x<0 и y<0 ");
    break;

     case 4:
    System.Console.WriteLine("В четвертой четверти x>0 и y<0 ");
    break;
}

