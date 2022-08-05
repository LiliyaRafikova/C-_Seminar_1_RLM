
 Console.WriteLine("Программа, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго!");
Console.WriteLine("Введите первое число: ");
 int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 == number_2 * number_2)
        {
            Console.WriteLine("Ответ: Да, первое число является квадратом второго!");
        }
    else
        {
            Console.WriteLine("Ответ: Нет, первое число не является квадратом второго!");
        }
 