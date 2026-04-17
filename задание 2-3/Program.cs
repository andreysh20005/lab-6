using System;

internal class Program
{
    private static void Main(string[] args)
    {

        Time t1 = new Time(10, 30);
        Time t2 = new Time(23, 45);
        Time t3 = new Time(5, 15);
        Time t4 = new Time(6, 0);
        Time t5 = new Time(25, 70); // проверка нормализации

        Console.WriteLine("Конструкторы и ToString():");
        Console.WriteLine($"t1 = {t1}");
        Console.WriteLine($"t2 = {t2}");
        Console.WriteLine($"t3 = {t3}");
        Console.WriteLine($"t4 = {t4}");
        Console.WriteLine($"t5 (25,70) -> {t5}");
        Console.WriteLine();


        Console.WriteLine("Оператор вычитания (Time - Time):");
        Time diff1 = t2 - t1;
        Time diff2 = t1 - t2;
        Time diff3 = t1 - t3;
        Console.WriteLine($"{t2} - {t1} = {diff1}");
        Console.WriteLine($"{t1} - {t2} = {diff2}");
        Console.WriteLine($"{t1} - {t3} = {diff3}");
        Console.WriteLine();

        Console.WriteLine("Унарные ++ и --:");
        Time t6 = new Time(23, 59);
        Console.WriteLine($"t6 = {t6}");
        t6++;
        Console.WriteLine($"t6++ = {t6}");
        t6--;
        Console.WriteLine($"t6-- = {t6}");
        Time t7 = new Time(0, 0);
        Console.WriteLine($"t7 = {t7}");
        t7--;
        Console.WriteLine($"t7-- = {t7}");
        t7++;
        Console.WriteLine($"t7++ = {t7}");
        Console.WriteLine();


        Console.WriteLine("Неявное приведение к int:");
        int minutes1 = t1;
        int minutes2 = t2;
        Console.WriteLine($"{t1} -> {minutes1} минут");
        Console.WriteLine($"{t2} -> {minutes2} минут");
        Console.WriteLine();

        Console.WriteLine("Явное приведение к bool:");
        Console.WriteLine($"(bool){t1} = {(bool)t1}");
        Console.WriteLine($"(bool){t4} = {(bool)t4}");
        Console.WriteLine();

        Console.WriteLine("Сравнение (< и >):");
        Console.WriteLine($"{t1} < {t2} = {t1 < t2}");
        Console.WriteLine($"{t1} > {t2} = {t1 > t2}");
        Console.WriteLine($"{t1} < {t3} = {t1 < t3}");
        Console.WriteLine($"{t1} > {t3} = {t1 > t3}");
        Console.WriteLine($"{t1} < {t1} = {t1 < t1}");
        Console.WriteLine();
    }
}