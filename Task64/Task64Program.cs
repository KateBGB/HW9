// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNaturalNumbers(int N, int i)
{
    if(i>N) return;
    ShowNaturalNumbers(N, i+1);
    Console.Write(i + ", ");
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Задать число N
int N = EnterData("Введите число N: ");
int i = 2;

// Вывести все натуральные числа от N до 1
ShowNaturalNumbers(N,i);
Console.Write(1);