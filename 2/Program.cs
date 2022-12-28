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

// Массив поиска строки, с наименьшой суммой элементов
void SearchRows(int[,] arr, int[] num)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        num[i] = sum;
    }
    Console.WriteLine("[{0}]", string.Join(", ", num));
    int min = num[0];
    int indexElement = 0;
    for(int i = 0; i < num.Length; i++)
    {
        if(num[i] < min)
        {
            min = num[i];
            indexElement = i;
        }
    }
    Console.WriteLine($"Строка с наименьшой суммой элементов: {indexElement + 1}");
}

int[,] array = new int[4, 4];

// Одномерный массив нужен для метода SearchRows выше, так как в него кладётся сумма элементов каждой строки
int[] numbers = new int[array.GetLength(1)];

FillRandomArray(array);
PrintArray(array);
Console.WriteLine("-------");
SearchRows(array, numbers);