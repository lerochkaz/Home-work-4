﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();
Console.Write("Введите число А: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int power = int.Parse(Console.ReadLine()!);

int toPower(int number, int power)
{
    validate(power);
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result = result * number;
    }

    return result;
}

void validate(int power)
{
    if (power < 0)
    {
        throw new Exception("Ошибка ввода");
    }
}

try
{
    int calculationResult = toPower(number, power);
    Console.WriteLine(calculationResult);
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}