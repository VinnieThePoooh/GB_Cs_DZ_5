// // Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет
//   количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


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

int FillNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i<lenght; i++) 
    {
        if (array[i]%2==0)
        result +=1;
    }

    return result;
}

int[] array = CreateArray(lenght);
PrintArray(array);
System.Console.WriteLine(FillNumber(array));