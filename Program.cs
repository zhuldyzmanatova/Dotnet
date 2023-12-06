// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());   //256

if(num>99 && num<1000)    //   && - и   || - или
{
int num1= num /100;   //  2
int num3 = num % 10;   //  6
int result = num1*10 + num3;
Console.WriteLine(result);
}
else
{
Console.WriteLine("Число не подходит");
}
