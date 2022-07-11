/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Zadacha38();

void Zadacha38()
{
    int size = 4;
    double[] array = new double[size];
    FillArray(array, -100, 101);
    PrintArray(array);
    DifMinMax(array);
}

void DifMinMax(double[] array)
{
    double min = 0;
    double max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна: {max - min}");
}


void FillArray(double[] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}