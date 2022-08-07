// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое чисо");
int num = Convert.ToInt32(Console.ReadLine());
int square  = num * num;
Console.Write($"Квадрат числа {num} = {square}");

Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Сегодня понедельник");
}
else if (a == 2)
{
    Console.WriteLine("Сегодня вторник");
}
else if (a == 3)
{
    Console.WriteLine("Сегодня среда");
}
else if (a == 4)
{
    Console.WriteLine("Сегодня четверг");
}
else if (a == 5)
{
    Console.WriteLine("Сегодня пятница");
}
else if (a == 6)
{
    Console.WriteLine("Сегодня суббота");
}
else if (a == 7)
{
    Console.WriteLine("Сегодня воскресенье");
}
else 
{
     Console.WriteLine("Некорректный ввод");
}
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a)
{
    Console.WriteLine($"{a} является квадратом {b}");
}
else
{
    Console.WriteLine($"{a} не является квадратом {b}");
}
Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a < 1000)
{
    Console.WriteLine($"Последняя цифра числа {a}={a % 10}");
}
else
    Console.WriteLine("Вы ввели не трезхначное число, повторите попытку");
