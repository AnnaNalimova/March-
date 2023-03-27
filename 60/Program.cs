// Сформулируйте трехмерный массив из неповторяющихся двузначных чисел.
//Напишите программу , которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Write("Введите размеры массива через пробел: ");
string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] arr = GetArray(new int[] { int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]) }, 1, 50);
PrintArray(arr);


int[,,] GetArray(int[] length, int min, int max)
{
    int[,,] mass = new int[length[0], length[1],length[2]];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            int k = 0;
            while (k < mass.GetLength(2))
            {
                int res = new Random().Next(min, max + 1);
                if (FindElement(mass, res)) continue;
                mass[i, j, k] = res;
                k++;
            }
        }
    }
    return mass;
}


bool FindElement(int[,,] array, int a)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (arr[i, j, k] == a) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

