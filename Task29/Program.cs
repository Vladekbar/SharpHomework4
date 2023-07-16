//Задача 29: Напишите программу, которая задаёт массив из рандомного числа элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] MakeRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100); // Запрет вывода трехзначных чисел.
    return array;
}

int[] array = MakeRandomArray(new Random().Next(42)); // больше в терминал не влезет. 
// Для вывода массива на 3 либо 5 элементов, как в примере задачи, следует метод Next заполнить как Next(3,6)
Console.WriteLine("[" + string.Join(", ", array) + "]");
