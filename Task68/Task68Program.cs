﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n);
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}


int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterData("Введите число M: ");
int n  = EnterData("Введите число N: ");

int Akkermanfunc = Akkerman(m,n);
Console.Write($"Функция Аккермана = {Akkermanfunc} ");
