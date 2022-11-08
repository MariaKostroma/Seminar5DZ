// Задача34. Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] InitialArr(int size, int begin=100, int last=999)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(begin,last+1);
    }
  return arr;
}

int CountEvenNum(int [] arr)
{
  int count = 0;
  for (int i = 0; i <arr.Length; i++)
  {
   if (arr[i] % 2 == 0) count++; 
  }
  return count;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      System.Console.Write(arr[i]+" ");  
    }
}

int[]arr=InitialArr(10);
PrintArray(arr);
int Count = CountEvenNum(arr);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {Count}");


//Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//стоящих на нечётных позициях.

arr=InitialArr(10);
PrintArray(arr);
Console.WriteLine();

int GetSumOdd(int[] array)
{
  int sum=0;
  for (int i = 0; i < array.Length; i++)
  {
    if(i % 2 == 1) sum += array[i];
  }
  return sum;
}

Console.WriteLine($"Сумма элементов на нечётных позициях {GetSumOdd(arr)}");


//Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементами массива.

double[] startArrayDouble = GetArrayDouble(5, 0, 100);
Console.WriteLine(String.Join(" ", startArrayDouble));
Console.WriteLine($"Разница {GetDifference(startArrayDouble)}");
double[] GetArrayDouble(int size, int minValue, int maxValue)

{
  double[] res = new double[size];
  var random = new Random();
  for (int i = 0; i < size; i++)
  {
    res[i] = random.Next(minValue, maxValue + 1) + random.NextDouble();
  }
  return res;
}

double GetDifference(double[] array)
{
  double min = array[0];
  double max = array[0];
  foreach (var item in array)
  {
    if (min > item) min = item;
    if (max < item) max = item;
  }
  return max - min;
}