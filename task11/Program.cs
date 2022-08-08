/* 
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98





16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет


*/


int randomNumber = new Random().Next(100, 999);
Console.WriteLine(randomNumber);

int firstNumber = randomNumber / 100;
int secondNumber = randomNumber % 10;
Console.Write($"{firstNumber}{secondNumber}");
