// Напишите программу, которая принимает на вход два числа и проверяет
// является ли одно число квадратом другого
// 5,25 - да
//8,9 - нет
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA*numberA == numberB || numberB*numberB == numberA)
{
    Console.WriteLine("Одно число является квадратом другого числа");
}
else Console.WriteLine("число не является квадратом другого числа");