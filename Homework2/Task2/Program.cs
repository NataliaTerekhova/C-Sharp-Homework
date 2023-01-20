//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    int result = number/100 %10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}