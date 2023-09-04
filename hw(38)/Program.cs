// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2} | ");
        else Console.Write($"{arr[i]:F2}");
    }
    Console.Write("]");
}

double[] arr = CreateArrayRndDouble(10, 1, 10);
PrintArray(arr);

double minNum = arr[0];
double maxNum = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > maxNum) maxNum = arr[i];
    else if (arr[i] < minNum) minNum = arr[i];
}

double difference = maxNum - minNum;
Console.Write($" => {maxNum:F2} - {minNum:F2} = {difference:F2} ");
