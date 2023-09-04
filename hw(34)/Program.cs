// Задайте массив заполненный случайными положительными трёхзначниыми числами.
// Напишите программу, которая покажет кол-во четных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int QuantityEvenNumbers(int[] arr)
{
    int sumEvenNumbers = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) sumEvenNumbers += 1;
    }
    return sumEvenNumbers;
}

int SizeArray (string size)
{
    Console.Write("Введите размер массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

int sizeArr = SizeArray(" ");
int[] arr = CreateArrayRndInt(sizeArr, 100, 999);
PrintArray(arr);
int res = QuantityEvenNumbers(arr);
Console.WriteLine($"Кол-во четных чисел в массиве -> {res}");