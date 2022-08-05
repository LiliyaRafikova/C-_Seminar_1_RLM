// See https://aka.ms/new-console-template for more information
Console.WriteLine("Программа, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.");
// например 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
Console.Write("Введите любое целое число:  ");
int Number = Convert.ToInt32(Console.ReadLine());
int negativeNumber = Number*(-1);
while (negativeNumber<=Number)
{
    Console.Write(negativeNumber+" ");
    negativeNumber++;
}