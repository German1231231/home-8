// Метод заполнения рандомными числами двух массивов
void FillRandomTwoArrays(int[,] arr4, int[,] arr5)
{
    for(int i = 0; i < arr4.GetLength(0); i++)
    {
        Random rand = new Random();
        for(int j = 0; j < arr4.GetLength(1); j++)
        {
            arr4[i, j] = rand.Next(2, 5);
            arr5[i, j] = rand.Next(2, 5);
        }
    }
}

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

// Метод заполнение итогового массива, путем нахождения произведений матриц
int[,] ProductsOfMatrix(int[,] result, int[,] a, int[,] b)
{
    if(a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == a.GetLength(1))
    {
        for(int i = 0; i < a.GetLength(0); i++)
        {
            for(int j = 0; j < b.GetLength(1); j++)
            {
                for(int k = 0; k < a.GetLength(1); k++)
                {
                    result[i,j] += a[i,k] * b[k,j]; 
                }
            }
        }
    return result;
    }
    else
    {
        Console.WriteLine("Ошибка");
        return result;
    }
}

int [,] arr1 = new int[2, 2];
int [,] arr2 = new int[2, 2];

//Пустая матрица для заполнения методом ProductsOfMatrix
int [,] arr3 = new int[2, 2];

FillRandomTwoArrays(arr1, arr2);
PrintArray(arr1);
Console.WriteLine("---");
PrintArray(arr2);
Console.WriteLine("---");
Console.WriteLine("---");
// Записываем в метод ProductsOfMatrix первым значением arr3, так как его заполняем, вторым значением arr1, третьим arr2
ProductsOfMatrix(arr3, arr1, arr2);
PrintArray(arr3);