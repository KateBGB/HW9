// //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void ShowSumofNumbers(int m, int n, int sum)

{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {sum} ");
    return;
  }
  ShowSumofNumbers(m, n - 1, sum);
}


int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterData("Введите число M: ");
int n  = EnterData("Введите число N: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

ShowSumofNumbers(m,n, temp =0);

