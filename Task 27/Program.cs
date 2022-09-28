// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "0";

int[] inputToArra(string input)
{
    int size = input.Length;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(input[i].ToString());
    }
    return array;
}


int resultOutput(int[] array)
{
    int lenghtArray = array.Length;
    int result = 0;
    for (int j = 0; j < lenghtArray; j++)
    {
        result = result + array[j];
    }

    return result;
}


int[] finishArray = inputToArra(userInput);
int finishResult = resultOutput(finishArray);
Console.WriteLine(finishResult);




