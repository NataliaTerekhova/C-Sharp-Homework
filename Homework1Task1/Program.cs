// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите первое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    System.Console.WriteLine(number1 + "- это наибольшее число, а " + number2 + " - это наименьшее число.");
}
else{
    System.Console.WriteLine(number2 + "- это наибольшее число, а " + number1 + " - это наименьшее число.");
}