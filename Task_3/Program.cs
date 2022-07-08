/*
    Задача 29: 
    Напишите программу, которая задаёт массив 
    из 8 элементов и выводит их на экран.
*/

int[] Num = new int[8];

Console.Write("Хотите цифорки писать(д/н): ");
string? user = Console.ReadLine();

if (user == "д")
{
    for (int i = 0; i <= 7; i++)
    {
        Console.Write("введите число: ");
        Num[i] = Convert.ToInt32(Console.ReadLine());
    }
}
else
{
    for (int i = 0; i <= 7; i++) Num[i] = new Random().Next(-999, 1000);
}

Console.WriteLine("[" + string.Join(",", Num) + "]");