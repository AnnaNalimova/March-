//  Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите число строк для  1 массива :");
int rowsFirst=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов для  1 массива :");
int columnsFirst=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число строк для  2 массива :");
int rowsSecond=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов для  2 массива :");
int columnsSecond=int.Parse(Console.ReadLine()!);
int[,] First=GetArray(rowsFirst,columnsFirst,5,9);
int[,] Second=GetArray(rowsSecond,columnsSecond,5,9);
PrintArray(First);
Console.WriteLine();
PrintArray(Second);
Console.WriteLine();
int[,]Third=GetMultiMatr(First,Second);
PrintArray(GetMultiMatr(First,Second));



if(rowsFirst!=columnsSecond)
{
  Console.WriteLine("Умножение не возможно!");
  return;
}


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
int[,] GetMultiMatr(int[,] mass1,int[,] mass2)
{
    int[,]mass3=new int[mass1.GetLength(0),mass2.GetLength(1)];
    for(int i=0;i<mass1.GetLength(0);i++)
    {
      for( int j=0;j<mass2.GetLength(1);j++)
      {
        for( int s=0;s<mass1.GetLength(1);s++)
        {
            mass3[i,j]=mass3[i,j]+mass1[i,s]*mass2[s,j];
        }
      }
    }
    return mass3;

}
