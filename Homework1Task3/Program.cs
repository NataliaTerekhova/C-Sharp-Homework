// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.Write("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());
if (number%2 ==0)
{
    System.Console.WriteLine(number + " - это четное число");
}
else{
  System.Console.WriteLine(number + " - это нечетное число");  
}