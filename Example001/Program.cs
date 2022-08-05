Console.WriteLine("Программа, которая на вход принимает число и выдаёт его квадрат!");
Console.Write("Введите любое целое число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number*number;
Console.Write("Ответ: ");
Console.WriteLine(result);