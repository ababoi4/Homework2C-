// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46

int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}

int number = new Random().Next(100, 999);
System.Console.WriteLine(number);

int number1 = number / 100;
int number3 = number % 10;

System.Console.WriteLine($"{number1}{number3}");


