// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Ограничения:
// - Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
// - Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода


int[] numberGeneration()
{
    Random random = new Random();
    int size = 8;
    int[] dataArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        dataArray[i] = random.Next(0, 100);
    }
    return dataArray;
}

void printResult(int[] data)
{
    string result = String.Join(", ", data);
    Console.Write($"[{result}]");
}

Console.Clear();
int[] array = numberGeneration();
printResult(array);



// Еще один вариант функции printResult и ее вызов.
// void printResult()
// {
//     int[] resultArray = numberGeneration();
//     string result = String.Join(", ", resultArray);
//     Console.Write($"[{result}]");
// }

// printResult();

