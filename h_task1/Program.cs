/*
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int num1 = new Random().Next(-10, 10);  // генерируем случайное число 1
Console.WriteLine("number one: " + num1); // выводим число 1
int num2 = new Random().Next(-10, 10);  // генерируем случайное число 2
Console.WriteLine("number two: " + num2); // выводим число 2

if (num1 > num2) // если число 1 больше числа 2
{
    Console.WriteLine("Maximum number = " + num1); // выводим, что макс число 1
}
else if (num1 < num2) // иначе если число 1 меньше чем число 2
{
    Console.WriteLine("Maximum number = " + num2); // выводим, что макс число 2
}
else {  // иначе
    Console.WriteLine("The numbers are equal"); // числа равны
};
