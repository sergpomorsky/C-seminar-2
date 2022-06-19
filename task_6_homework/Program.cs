// Напишите программу, котора выводит третью цифру заданого числа или
//сообщает, что этой цифры нет
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
// if (number > 100 || number < 1000)
// {
//     Console.WriteLine(number%10);
// } 
//else
// {
//     string unknown_number = number.ToString();
//     Console.WriteLine(unknown_number[2]);
// }
else
{
    while (number > 999)
    {
        number = number/10;
    }
    Console.WriteLine(number%10);
}