// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int FindMax (int [] array)
{
    int max = 0;
    int n = array.Length;
    for (int i =0; i<n; i++)
    if (array[i]>max) max=array[i];
    return max;
}

int FindMin (int [] array)
{
    int min = array[0];
    int n = array.Length;
    for (int i =0; i<n; i++)
    if (array[i]<min) min=array[i];
    return min;
}

int[] s = NewArr(4, 1, 26);
int max = FindMax(s);
int min = FindMin(s);
Console.WriteLine("");
Console.WriteLine("Разница равна " + (max-min));