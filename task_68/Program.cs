// Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
System.Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int AkkermanFunc (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunc(m-1,1);
    else if (m > 0 && n > 0) return AkkermanFunc(m-1,AkkermanFunc(m,n-1));
    else return 0;
}
int a = AkkermanFunc(number1, number2);
System.Console.WriteLine(a);