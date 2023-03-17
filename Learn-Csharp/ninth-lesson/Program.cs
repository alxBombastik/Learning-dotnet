/*
 
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

int GetNumbers(int number)
{
    if(number == 1)
    {
        Console.Write($"{number}.");
        return 1;
    }
    Console.Write($"{number}, ");
    return GetNumbers(number - 1);
}

void Task64()
{
    GetNumbers(6);
}

//Task64();

/*

Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSumOfTwoNumbers(int m, int n)
{    
    return m >= n ? n : m + GetSumOfTwoNumbers(m + 1, n);
}

void Task66()
{
    Console.WriteLine(GetSumOfTwoNumbers(1, 15)); 
}

//Task66();

/*

Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 

*/

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0)
    {
        return AkkermanFunction(m - 1, n);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}

void Task68()
{
    Console.WriteLine(AkkermanFunction(1, 2));
}
Task68();