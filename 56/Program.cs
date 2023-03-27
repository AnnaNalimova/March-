// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] massive = GetArray(rows, columns, 0, 10);
PrintArray(massive);
int result=FindNumberRow(massive);
Console.WriteLine();
Console.WriteLine($"Искомая строка - {result}");

int[,] GetArray(int a, int b, int min,int max)
{
    int[,]arr=new int[a,b];
    for(int i=0;i<a;i++)
    {
      for(int j=0;j<b;j++)
      {
        arr[i,j]=new Random().Next(min,max+1);
      }
    }
    return arr;
}

void PrintArray(int[,] mass)
{
   for (int i=0;i< mass.GetLength(0);i++)
   {
     for( int j=0;j< mass.GetLength(1);j++)
     {
       Console.Write($"{mass[i,j]}");
     }
     Console.WriteLine();
   }
}
int FindNumberRow(int[,] arr)
{
    int find = 0;
    int res1 = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        res1 = res1 + arr[0, i];
    }

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int res2 = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res2 = res2 + arr[i, j];
        }
        if (res1 > res2)
        {
            res1 = res2;
            find = i;
        }
    }
    return find;
}


