// 34. Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел.

int[] array = new int[10];
FillArray(array);
Console.WriteLine("Полученный массив:");
PrintArray(array);
int count = GetEvenCount(array);
Console.WriteLine($"Кол-во чётных чисел - {count}");


void FillArray(int[] num) // метод для заполнения массива
{
    // int length = numbers.Length;
    int index = 0;
    while (index < num.Length)
    {
        num[index] = new Random().Next(100, 999);
        index++;
    }
}

void PrintArray(int[] num) // метод для вывода массива на экран
{
    // int length = num.Length;
    int pos = 0;
    while (pos < num.Length)
    {
        Console.Write($"{num[pos]} ");
        pos++;
    }
    Console.WriteLine();
}


int GetEvenCount(int[] num) // метод подсчёта кол-ва чётных чисел
{
    int count = 0;
    for (int i = 0; i < num.Length - 1; i++)
    {
        if (num[i] % 2 == 0) count++;
    }
    return count;
}


