// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


void PrintMIsLessThanN(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m} ");
    PrintMIsLessThanN(m + 1, n);
}

void PrintNIsLessThanM(int m, int n) 
{
    if (m < n) return;
    Console.Write($"{m} "); 
    PrintNIsLessThanM(m - 1, n);
}

Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

if (m < n)
{
    PrintMIsLessThanN(m,n);
}
else
{
    PrintNIsLessThanM(m,n);
}
