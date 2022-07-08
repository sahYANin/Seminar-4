/*
    Задача 25: 
    Напишите цикл, который принимает на вход два числа (A и B) 
    и возводит число A в натуральную степень B.
*/

int a, b,c, i = 2;

Console.Write("Введите первое чило: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

for (c = a; i <= b; i++)
{
    c = c * a;
    // Console.WriteLine(c);
    // Console.WriteLine(i);
}
Console.Write("Ответ: ");
Console.WriteLine(c);