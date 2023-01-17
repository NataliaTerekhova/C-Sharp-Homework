// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int currentN=2;
while (currentN<=N)
{
    System.Console.Write(currentN + " ");
    currentN=currentN+2;
}