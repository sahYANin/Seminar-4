/*
    Задача 27: 
    Напишите программу, которая принимает на вход число 
    и выдаёт сумму цифр в числе.
*/

int a, a1, s, i;

Console.Write("Введите число, свыше двух цифр: ");
a = Convert.ToInt32(Console.ReadLine());

for (s = a, i = 0; s > 0; i++) s /= 10;
// Console.WriteLine(i);
if (i < 0)
{
    for (a1 = a; i >= 0; i--)
    {
        s = (a % 10) + s;
        a1 /= 10;
        a = a1;
    }
    Console.Write("Ответ: ");
    Console.WriteLine(s);
}
else Console.Write("Некорректное число");

