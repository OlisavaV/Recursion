// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int PrintAck(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return PrintAck(n - 1, 1);
    return PrintAck(n - 1, PrintAck(n, m - 1));
}

Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintAck(n, m));