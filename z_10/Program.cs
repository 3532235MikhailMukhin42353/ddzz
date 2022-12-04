// Программа, на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа.
try
{
    Console.WriteLine("Введите трехзначное число");
    int X = Convert.ToInt32(Console.ReadLine());
    int numberA = X / 10;    
    int numberB = numberA % 10;
    if (X > 99 && X < 1000) Console.WriteLine($"Заданная цифра трехзначная. Вторая её цифра = {numberB} ");
    else Console.WriteLine("Заданная цифра не трехзначная!");
}
catch
{
    Console.WriteLine("Нужно вводить именно цифры!");
}