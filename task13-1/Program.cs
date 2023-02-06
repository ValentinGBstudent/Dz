// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Я всёже понял как решать без массивапосле того как загрузил. Но опять ругается на слишком большие 
// цифры

Console.Clear();
Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int num3 = 0;
if(num < 100)
{
    Console.Write("no third digit");
}
else
{
    while(num >= 1000)
    {
        num = num / 10;
    }
    num3 = num % 10;
    Console.Write(num3);
}