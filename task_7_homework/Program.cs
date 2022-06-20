// Напишите программу, которая принbмает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Set number day");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number == 1)
{
    Console.WriteLine("no");
}
if (number == 2)
{
    Console.WriteLine("no");
}
if (number == 3)
{
    Console.WriteLine("no");
}
if (number == 4)
{
    Console.WriteLine("no");
}
if (number == 5)
{
    Console.WriteLine("no");
}
if (number == 6)
{
    Console.WriteLine("yes");
}
if (number == 7)
{
    Console.WriteLine("yes");
}
if (number > 7 || number == 0)
{
    Console.WriteLine("go to work!");
}