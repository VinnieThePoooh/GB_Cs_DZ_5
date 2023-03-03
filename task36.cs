// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

System.Console.WriteLine("Введите размер массива");
int lenght = Convert.ToInt32(Console.ReadLine());


double[]CreateArray (int lenght)
{
    double[] array = new double[lenght];
    for (int i = 0; i<lenght; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray (double[] array)
{
    System.Console.WriteLine($"Сгенерированный массив: [{string.Join(", ", array)}]");
}

double[] FindMinMax (double[] array)
{
    int minIndex = 0;
    int maxIndex = 0;
    for (int i = 0; i < lenght; i++)
    {
        if (array[i]<array[minIndex])
        {
            minIndex = i;
        }
        else if (array[i]>array[maxIndex])
        {
            maxIndex = i;
        }
    }
    double[] minMax = new double[2];
    minMax[0] = array[minIndex];
    minMax[1] = array[maxIndex];
    return minMax;
}

double[] array = CreateArray(lenght);
PrintArray(array);
double[] minMax = FindMinMax(array);
System.Console.WriteLine($"Минимальное и максимальное значения: {string.Join(", ", minMax)}");
System.Console.WriteLine($"Разница между максимальным и минимальным равна: {minMax[1] - minMax[0]} ");