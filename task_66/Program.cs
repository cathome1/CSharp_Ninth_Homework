// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumOfNums (int num1, int num2)
{
    if (num1 < num2)
    {
        return num1 + SumOfNums(num1 + 1, num2); 
    }
    if (num1 > num2) return SumOfNums(num2,num1);
    else return num2;
}
// int FixEquals (int num1, int sum)   // этот код нужен для случаев 
// {                                   // когда числа равны, но 
//     if (num1 == sum) return num1 + num1; // я не уверен что он нужен
//     else return sum;                               // т.к. между числами нет чисел
// }
int summa = SumOfNums(number1,number2);
System.Console.WriteLine(summa); // если тот код нужен, то здесь в скобках FixEquals(number1,summa)