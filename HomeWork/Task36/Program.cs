// Задача 36: Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int UnEven (int [] array)
{
    int size = array.Length;
    int result = 0;
    for (int i = 1; i<size; i=i+2)
    {result += array[i];}
    return result;
}

int[] s = NewArr(4, 1, 26);
int res = UnEven(s);
Console.WriteLine("");
Console.WriteLine(res);
