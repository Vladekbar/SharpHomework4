//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

int Elevation(int baseNum, int expNum)
{
    int result = 1;
    for (int i = 0; i < expNum; i++)
    {
        result *= baseNum;
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetInfo("Введите число A: ");
int numberB = GetInfo("Введите число В: ");
Console.WriteLine(numberA + ", " + numberB + " -> " + Elevation(numberA, numberB));