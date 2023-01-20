// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<6)
{
    System.Console.WriteLine("Это не выходной");
}
else{
    System.Console.WriteLine("Это выходной");
}