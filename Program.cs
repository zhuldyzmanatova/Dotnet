#pragma warning disable

// Задача 1 - Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());   //256

// if(num>99 && num<1000)    //   && - и   || - или
// {   
//     int num1= num /100;   //  2
//     int num3 = num % 10;   //  6
//     int result = num1*10 + num3;
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("Число не подходит");
// }

// Задача 2 - Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// Решение 1
// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// if (num > 99 && num < 1000) // проверка на трехзначное число
// {
//     int num1 = (num / 10) % 10;
//     int num2 = num % 10;
//     int result = 1;
//     while (num2 >= 1)
//     {
//         result = result * num1;
//         num2--;
//     }
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("Число не подходит");
// };

// Решение 2
// Console.WriteLine("Введите трехзначное число");
// int number = int.Parse(Console.ReadLine());
// if (number>99 && number < 1000) 
// {
//     int num1 = Math.Abs(number) / 10 % 10;
//     int num2  = number % 10;
//     double num3 = Math.Pow(num1,num2);
//     Console.WriteLine(num3);
// }
// else
// {
//     Console.WriteLine("Введено неверное число");
// }

// Задача 3 - Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// Console.WriteLine("Введите первое число");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int b = int.Parse(Console.ReadLine());

// if (a%b == 0)
// {
// Console.WriteLine($"{a}, {b} => да");
// }
// else
// {
// Console.WriteLine($"{a}, {b} => нет, {a%b}");
// }

// Задача 4 - Напишите программу, которая выводит третью с начала
// цифру заданного числа или сообщает, что третьей цифры нет.
// 456 => 6
// 345678 - 5
// 91 => Третьей цифры нет

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// if(num>99)
// {
//     while(num>999)
//     {
//         num = num/10;
//     }
//     Console.WriteLine(num % 10);
// }
// else
// {
//     Console.WriteLine("Число не подходит");
// }