// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
int max = 0;
Console.WriteLine("Enter fist number: ");
int number1 = int.Parse(Console.ReadLine());
if(number1 > max)
{
    max = number1;
}
Console.WriteLine("Enter second number: ");
int number2 = int.Parse(Console.ReadLine());
if(number2 > max)
{
    max = number2;
}
Console.WriteLine("Enter third number: ");
int number3 = int.Parse(Console.ReadLine());
if(number3 > max)
{
    max = number3;
}
Console.Write(max + " bigest number");
