/*
Задача 4:  Напишите программу, которая на вход принимает число (N), а на выходе 
показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int num = new Random().Next(1, 10);  
Console.Write(num + " ");

int count = 0;
Console.Write("-> ");

while (count < num)
{
  if (num % 2 == 0) {
    count += 2;
  }
  else {
    num -= 1;
    count += 2;
  }
  Console.Write(count + ", ");
}
