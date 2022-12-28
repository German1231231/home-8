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
        //Console.ReadKey();
    }
}

// Метод заполнения рандомными числами массива
void FillRandomArray(int[,] arr, int[] num)
{
    int count = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Random rand = new Random();
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(10, 100);
            num[count] = arr[i, j];
            count++;
        }
    }
}

// Метод, который меняет повторяющиеся числа
void CheckNumbersArray(int[] arr)
{
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = i; j < arr.Length - 1; j++)
        {
            if(arr[i] == arr[j + 1])
            {
                arr[j + 1] = rand.Next(10,99);
            }
        }
    }
}

//
void FillArrayy(int[,] num, int[] arr)
{
    int count = 0;
    for(int i = 0; i < num.GetLength(0); i++)
    {
        for(int j = 0; j < num.GetLength(1); j++)
        {
            num[i,j] = arr[count];
            count++;
        }
    }
}

int[,] array = new int[5,5];
int[] numbers = new int[array.GetLength(0) * array.GetLength(1)];

FillRandomArray(array, numbers);
PrintArray(array);
Console.WriteLine("[{0}]", string.Join(", ", numbers));
Console.WriteLine("------");
CheckNumbersArray(numbers);
Console.WriteLine("[{0}]", string.Join(", ", numbers));
FillArrayy(array, numbers);
PrintArray(array);