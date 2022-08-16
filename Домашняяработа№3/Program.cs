// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = number % 10;
// int b = number / 10000;
// if (a==b)
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine("Нет");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// Console.WriteLine("Введите x1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите c1: ");
// int c1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите c2: ");
// int c2 = int.Parse(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(c1-c2,2));
// Console.WriteLine($"d={d:f2}");

// Задача 23
// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.Write("Введите число N, я выведу таблицу кубов чисел от 1 до N: ");
// int N=Convert.ToInt32(Console.ReadLine());
// int ind = 1;
// if (N>0)
// {
//     while (ind<=N)
//     {
//         Console.Write(Math.Pow(ind,3) + ", ");
//         ind=ind+1;
//     }
// }
// else
// {
//     while (ind>=N)
//     {
//         Console.Write(Math.Pow(ind,3) + ", ");
//         ind=ind-1;
//     }
// }    





