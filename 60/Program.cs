// Сформулируйте трехмерный массив из неповторяющихся двузначных чисел.
//Напишите программу , которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите  размеры массива через пробел: ");
string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] massive = GetArray(new int[] { int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]) }, 1, 7);
PrintArray(massive);
if (FindEl(mass, res)) continue;
int[,,] GetArray(int[] length, int min, int max)
{
    int[,,] mass = new int[length[0], length[1], length[2]];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            int k = 0;
            while (k < mass.GetLength(2))
            {
                int res = new Random().Next(min, max + 1);
                if (FindEl(mass, res)) continue;
                mass[i, j, k] = res;
                k++;
            }
        }
    }
    return mass;
}


bool FindEl(int[,,] arr, int box )
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == box) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
               Console.Write($"{arr[i, j, k]} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

