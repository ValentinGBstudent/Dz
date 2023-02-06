﻿// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Enter x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter z2: ");
int z2 = int.Parse(Console.ReadLine());

int length = x2 - x1;
int height = y2 - y1;
int width = z2 - z1;

double result = Math.Round(Math.Sqrt(length*length + height*height + width*width), 2);

Console.Write(result);