// Задайте двумерный массив.
// Напишите программу,которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Введите число строк  массива :");
int rows=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов  массива :");
int columns=int.Parse(Console.ReadLine()!);
int[,] massive=GetArray(rows,columns,2,9);
PrintArray(massive);
ChangeArr(massive);
Console.WriteLine();
PrintArray(massive);
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
void ChangeArr(int[,] arra)
{
    for( int i=0;i<arra.GetLength(0);i++)
    {
       for( int j=0;j<arra.GetLength(1);j++)
       {
         for( int k=j+1;k<arra.GetLength(1);k++)
         {
           if (arra[i,k]>arra[i,j])
           {
              int res=arra[i,j];
              arra[i,j]=arra[i,k];
              arra[i,k]=res;

           }
         }
       }


    }
}




