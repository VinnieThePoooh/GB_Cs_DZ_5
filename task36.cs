// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.WriteLine("Введите размер массива");
int lenght = Convert.ToInt32(Console.ReadLine());


int[]CreateArray (int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i<lenght; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray (int[] array)
{
    System.Console.WriteLine("["+ string.Join(", ", array)+"]");
}

int Sum (int[] array)
{
    int sum =0;
    for (int i = 1; i < lenght; i++)
    {
        if (i%2!=0)
        {
            sum +=array[i];
        }
    }
    return sum;
}

int[] array = CreateArray(lenght);
PrintArray(array);
System.Console.WriteLine(Sum(array));