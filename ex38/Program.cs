// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

int[] array = new int[10];
FillArray(array);
Console.WriteLine("Входной массив:");
PrintArray(array);
int minNum = MinDigital (array);
int maxNum = MaxDigital (array);
int result = DiffSearch (minNum, maxNum);
Console.WriteLine($"Мин.знач. {minNum}, макс.знач. {maxNum}, разница между ними {result}");


void FillArray(int[] num) // метод для заполнения массива
{
    // int length = numbers.Length;
    int index = 0;
    while (index < num.Length)
    {
        num[index] = new Random().Next(-100, 100);
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


int MinDigital (int[] num) // метод нахождения мин.числа
{
    int minNum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] < minNum)
        {
            minNum = num[i];
        }
    }
    return minNum;
}

int MaxDigital (int[] num) // метод нахождения макс.числа
{
    int maxNum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > maxNum)
        {
            maxNum = num[i];
        }
    }
    return maxNum;
}

int DiffSearch (int minNum, int maxNum) //метод нахождения разницы  
{
    int result = maxNum - minNum;
    return result;
}