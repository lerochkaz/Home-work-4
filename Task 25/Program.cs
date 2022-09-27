// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int numberB = int.Parse(Console.ReadLine()!);

int Power(int firstNumber, int secondNumber)
{
    int result = 1;
    for (int i = 1; i <= secondNumber; i++)
    {
        result = result * firstNumber;
    }
    return result;
}

int calculationResult = Power(numberA, numberB);
Console.WriteLine(calculationResult);