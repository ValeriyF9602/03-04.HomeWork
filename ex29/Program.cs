/**************************************************************************

Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

**************************************************************************/


// Подсмотрел в эталонное решение

int EnterNums(string text, int defoult)
{
    Console.Write(text + $" (по умолчанию {defoult}): ");
    string? str = Console.ReadLine();
    if (str != string.Empty) // if (str != "")
    {
        return Convert.ToInt32(str);
    }
    return defoult;

}

int[] FillArray(int length, int minimum, int maximum)
{
    Random rand = new Random();
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minimum, maximum + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}

int size = EnterNums("Укажите размер массива", 2);
int min = EnterNums("Минимальное занчение элемента массива", -15);
int max = EnterNums("Максимальное занчение элемента массива", 15);
int[] arr = FillArray(size, min, max);
PrintArray(arr);