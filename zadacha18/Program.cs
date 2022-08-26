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


// //  Напишите программу, которая по заданному
// // номеру четверти, показывает диапазон 
// // возможных координат точек в этой четверти 
// // (x и y)

// Console.WriteLine("Enter quater... ");
// int quaternumber = int.Parse(Console.ReadLine());
// if (quaternumber == 1)
// {
//     Console.WriteLine("x > 0, y > 0");

// }
// else if (quaternumber == 2)
// {
//     Console.WriteLine("x < 0, y > 0");

// }
// else if (quaternumber == 3)
// {
//     Console.WriteLine("x < 0, y < 0");

// }
// else if (quaternumber == 4)
// {
//     Console.WriteLine("x > 0, y < 0");

// }
// else
// {
//     Console.WriteLine("Bug Error");
// }

