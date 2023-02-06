// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Enter five digit number: ");
int num = int.Parse(Console.ReadLine());
char [] arr = num.ToString().ToCharArray();
if((arr.Length < 5) || (arr.Length > 5))
{
    Console.Write("its not five digit nember");
}
else
if((arr[0] == arr[4]) && (arr[1] == arr[3]))
{
    Console.Write("its polidrome");
}
else
{
    Console.Write("its not polidrome");
}
