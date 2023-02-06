// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();
Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
char [] arr = num.ToString().ToCharArray();
if(arr.Length < 3)
 {
     Console.Write("no third digit");
 }
 else
 {
     Console.Write(arr[2]);
 }