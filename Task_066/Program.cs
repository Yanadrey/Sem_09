// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int SumBetweenNumbers(int numberM, int numberN)
{
    if (numberM == numberN)
        return numberN;
    return numberM + SumBetweenNumbers(numberM + 1, numberN);
}

int numberM = InputNumber("Введите первое число: ");
int numberN = InputNumber("Введите второе число: ");
System.Console.WriteLine($"Сумма натуральных чисел в промежутке от {numberM} до {numberN} равна {SumBetweenNumbers(numberM, numberN)}");

