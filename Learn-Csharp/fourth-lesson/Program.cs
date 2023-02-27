/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

void task25(){
    Console.Write("Enter an A number >>> ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter an B number >>> ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);

}

//task25();

/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

void task27(){
    Console.Write("Enter a number >>> ");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    while(number > 0){
        result = result + number % 10;
        number /= 10;
    }
    Console.WriteLine(result);

}

task27();

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/