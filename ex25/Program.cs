/**************************************************************************

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

**************************************************************************/

int ReadInt(string text, int defoult)
{
    Console.Write(text + $" (по умолчанию {defoult}): ");
    string? result = Console.ReadLine();
    if (result != "")
    {
        return Convert.ToInt32(result);
    }
    return defoult;
}

void PowerNum(int number, int power)
{
    int result = number;

    if (power > 0)
    {
        for (int i = 1; i < power; i++)
        {
            result *= number;
        }

        Console.WriteLine($"Число {number} в степени {power}: {result}");
    }
    else
    {
        Console.WriteLine("Степень должна быть натуральной"); // "... и возводит число A в НАТУРАЛЬНУЮ степень B."
    }
}

Console.WriteLine();
Console.WriteLine("Возведение числа A в натуральную степень B");

int num = ReadInt("Введите число A", 0);
int pow = ReadInt("Введите натуральную степень B", 1); // "... и возводит число A в НАТУРАЛЬНУЮ степень B."
PowerNum(num, pow);

Console.WriteLine();