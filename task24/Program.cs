﻿/*
Напишите программу, которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А. 7 -> 28 4 -> 10 8 -> 36 
*/

// Задаем число A, создаем метод возвращаемого типа, 
//который будет выдавать сумму чисел от 1 до A.
// Задаем счетчик, который будет увеличиваться каждый проход цикла,
// добавляем переменную, которая будет содержать в себе сумму

Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()); //Parse - это метод перевода string в integer

int getSumNums(int number)
{
     int sum = 0;
     int i = 1;
     while(i <= number)
     {
        sum += i;
        i++;
     }
     return sum;
}
Console.WriteLine($"Сумма чисел от 1 до A = {getSumNums(num)}");