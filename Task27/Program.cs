//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

int SumOfDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int digit = num % 10; // Для получения последней цифры числа.
        sum += digit; // Добавляем эту цифру к сумме.
        num /= 10; // Убираем последнюю цифру числа. (В Цикл возвращается новое число без последней цифры).
    }
    return sum;
}

int GetInfo(string info)
{
    Console.Write(info);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");
Console.WriteLine(num + " -> " + SumOfDigits(num));