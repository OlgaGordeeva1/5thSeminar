// Задача 32: Напишите функцию замена элементов массива:
// положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] NewArr(int n, int min, int max)
{
    int[] arr = new int [n];
    for (int i=0; i<n; i++)
    {
        arr[i] = new Random().Next(min,max);
        Console.Write(arr[i]+" ");
    }
return arr;
}

int [] Change (int [] arr1)
{
    int size = arr1.Length;
    int [] New = new int [size];
    for (int i = 0; i < size; i++)
  {
    New [i] = -1*arr1[i];
    Console.Write(New [i] +" ");
  }
  return New;
}

int[] S = NewArr(4, -10, 10);
Console.WriteLine (" ");
int [] res = Change(S);
