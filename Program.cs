﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 //какое число большее, а какое меньшее.

Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.Write($"{a}==max, {b}==min");
    };
if (a<b)
{
    Console.Write($"{b}==max, {a}==min");
};