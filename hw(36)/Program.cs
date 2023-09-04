// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечетных позициях.

// [3, 7, 23, 19] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumElemNoEvenPosition(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i]; 
    }
    return sum;
}

int SizeArray (string sizeArray)
{
    Console.WriteLine("Введите размер массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

int MinNumArray (string minNumArray)
{
    Console.WriteLine("Введите минимальное число массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

int MaxNumArray (string sizeArray)
{
    Console.WriteLine("Введите максимальное число массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

int sizeArr = SizeArray (" ");
int minNumArr = MinNumArray (" ");
int maxNumArr = MaxNumArray (" ");

int[] arr = CreateArrayRndInt(7, 1, 10);
PrintArray(arr);
int sumIndexNoEvenPosition = SumElemNoEvenPosition(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна -> {sumIndexNoEvenPosition}");
