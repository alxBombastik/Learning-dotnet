//Задача 2: Напишите программу, которая на вход принимает два
//числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Задача 4: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Задача 6: Напишите программу, которая на вход принимает число и 
//выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
//
//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

int IsMax(int firstNumber, int secondNumber){
    if(firstNumber > secondNumber)
        return firstNumber;
    return secondNumber;
}

bool IsEven(int number) => number % 2 == 0;

void FirstTask(){
    Console.Write("Enter first number >>> ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number >>> "); 
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(IsMax(firstNumber, secondNumber));
}

void SecondTask(){
    Console.Write("Enter first number >>> ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number >>> "); 
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter third number >>> ");
    int thirdNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(IsMax(firstNumber,IsMax(secondNumber, thirdNumber)));
}

void ThirdTask(){
    Console.Write("Enter a number >>> ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(IsEven(number));
}

void FourthTask(){
    Console.Write("Enter a number >>> ");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 2; i <= number; i++)
    {
        if(IsEven(i))
            Console.Write($"{i} ");
    }
}

void FizzBuzz()
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

//FirstTask();
//SecondTask();
//ThirdTask();
//FourthTask();
FizzBuzz();