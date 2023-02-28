// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackermann(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    else if (numberN == 0)
        return Ackermann(numberM - 1, 1);
    else
        return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
}

metka:
int numberM = InputNumber("Введите первое число: ");
int numberN = InputNumber("Введите второе число: ");
if (numberM < 0 || numberN < 0)
{
    System.Console.WriteLine("Необходимо ввести положительные число. Повторите ввод!");
    goto metka;
}

System.Console.WriteLine($"Значение функции Аккермана для числел {numberM} и {numberN} равно {Ackermann(numberM, numberN)}");

