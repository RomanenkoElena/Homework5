// 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.

int[] array = new int[10];
FillArray(array);
Console.WriteLine("Входной массив:");
PrintArray(array);
int sum = Sum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях - {sum}");


void FillArray(int[] num) // метод для заполнения массива
{
    int index = 0;
    while (index < num.Length)
    {
        num[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] num) // метод для вывода массива на экран
{
    int pos = 0;
    while (pos < num.Length)
    {
        Console.Write($"{num[pos]} ");
        pos++;
    }
    Console.WriteLine();
}


int Sum(int[] num) // метод подсчёта суммы чисел на нечетных позициях
{
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + num[i];
        }
    }
    return sum;
}


