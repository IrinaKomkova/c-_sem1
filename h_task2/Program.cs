/*
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int num1 = new Random().Next(0, 100);  // генерируем число 1
Console.Write(num1 + " "); // выводим число 1
int num2 = new Random().Next(0, 100);  // генерируем число 2
Console.Write(num2 + " "); // выводим число 2
int num3 = new Random().Next(0, 100);  // генерируем число 3
Console.Write(num3 + " "); // выводим число 3
int MaxNum; // задаем переменную максимального числа


if (num1 > num2 && num1 > num3) {
  MaxNum = num1;
}
else if (num2 > num1 && num2 > num3) {
  MaxNum = num2;
}
else {
  MaxNum = num3;
}

Console.Write("-> " + MaxNum);
