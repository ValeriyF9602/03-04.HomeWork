/**************************************************************************

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

**************************************************************************/


int ReadInt(string text)
{
    Console.Write(text + " (по умолчанию 0): ");
    string? result = Console.ReadLine();

    if (result != "")
    {
        return Convert.ToInt32(result);
    }
    return 0;
}

int DigitCount(int number)
{
    if (number > 0)
    {
        int count = 0;

        while (number > 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
    else if (number == 0)
    {
        return 1;
    }
    return -1;
}

void PrintResult(int number, int count)
{
    if (count == -1)
    {
        Console.WriteLine("Неверное число");
    }
    else
    {
        int sum = 0;

        for (int i = 0; i < count; i++)
        {
            sum += number / (int)Math.Pow(10, i) % 10;
            
            if (i < count - 1)
            {
                Console.Write(number / (int)Math.Pow(10, count - 1 - i) % 10 + " + ");
            }
            else
            {
                Console.WriteLine($"{number / (int)Math.Pow(10, count - 1 - i) % 10} = {sum}");
            }
        }
    }
}

int num = ReadInt("Введите число");
int amount = DigitCount(num);
PrintResult(num, amount);