// Задача 15: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Enter day number: ");
int day = int.Parse(Console.ReadLine());
if((day == 6) || (day == 7))
{
    Console.Write("yes");
}
else
{
    Console.Write("no");
}