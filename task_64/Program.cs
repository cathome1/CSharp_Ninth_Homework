// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
System.Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void FromNumToOne (int num)
{
    if (num == 0) return;
    System.Console.Write($"{num}, ");
    FromNumToOne(num - 1);
}
FromNumToOne(number);