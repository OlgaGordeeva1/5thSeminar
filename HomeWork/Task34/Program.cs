// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] NewArr(int n, int min, int max)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(min, max);
        Console.Write(arr[i] + " ");
    }
    return arr;
}

int Even(int [] array)
{
    int size = array.Length;
    int result = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }
return result;
}

int[] s = NewArr(4, 100, 1000);
int res = Even(s);
Console.WriteLine("");
Console.WriteLine(res);