/*
Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


void FirstTask(){
    int number = new Random().Next(100, 1000);
    Console.WriteLine(number);
    if(number > 99 || number < 1000)
        number = (number/10)%10;
    Console.WriteLine(number);
}

/*
Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

*/

int TakeLastDigitInNumber(int number) => number % 10;

void SecondTask(){
    int number = new Random().Next(100, Int32.MaxValue);
    Console.WriteLine(number);
    while(number > 1000){
        number/=10;
    }  
    Console.WriteLine($"{number}'s third digit = {TakeLastDigitInNumber(number)}");
}

/*
Задача 15: Напишите программу, которая принимает на
 вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

bool CatchDayOfWeek(int number) => number == 6 || number == 7 ? true : false;

void ThirdTask(){
    int number = new Random().Next(1, 7);
    Console.WriteLine($"{number} -> {CatchDayOfWeek(number)}");
}

/*
После загрузки задания, вы можете проверить себя
 самостоятельно с помощью эталонного решения

***Напишите программу, которая выводит на экран числа
от 1 до 100. При этом вместо чисел, кратных трем, 
программа должна выводить слово «Fizz», а вместо чисел, 
кратных пяти — слово «Buzz». Если число кратно и 3, и 5, 
то программа должна выводить слово «FizzBuzz».(доп задача по желанию, разберем на семинаре)
*/

void FizzBuzzTask()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 15 == 0)
            Console.Write($"FizzBuzz ");
        else if(i % 3 == 0)
            Console.Write($"Fizz ");
        else if (i % 5 == 0)
            Console.Write($"Buzz ");
        else
            Console.Write($"{i} ");
    }
}
//FizzBuzz();
//FirstTask();
//SecondTask();
ThirdTask();