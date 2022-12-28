// Метод печати элементов массива
void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод заполнения рандомными числами массива
void FillRandomArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Random rand = new Random();
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(2, 10);
        }
    }
}

// Метод сортировки массива, от большего к меньшему
int[,] SortArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if(arr[i, k] > arr[i, k + 1])
                {
                    int tmp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = tmp;
                }
            }
        }
    }
    return arr;
}

int[,] array = new int[3, 4];

FillRandomArray(array);
PrintArray(array);
Console.WriteLine("-------");
SortArray(array);
PrintArray(array);