// написать программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа
int number = new Random().Next(100,999);
Console.WriteLine($"Наше случайное число = {number}");
int numberA = number/100;
int numberB = number/10 % 10;
int numberC = number % 10;
int result = numberA * 10 + numberC;
Console.WriteLine (result);