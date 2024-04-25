// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1 2 5  0 10 34] => 34 10 0 5 2 1


int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

void PrintElementInvertedArray (int[] array, int i)
{
    if (i < 0) return;
    Console.Write($"{array[i]} ");
    PrintElementInvertedArray(array, i -1);
}


Random rnd = new Random();
int sizearr = rnd.Next(1, 20);

int[] arr = CreateArrayRndInt(sizearr, 1, 100);
PrintArray(arr);

PrintElementInvertedArray(arr, arr.Length -1);
