// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
try
{
    Console.WriteLine("Введите трехзначное число");
    int X = Convert.ToInt32(Console.ReadLine());
    int numberA = X % 10;
    if (X > 99 && X < 1000) Console.WriteLine($"Заданная цифра трехзначная. Третья её цифра = {numberA} ");
    else Console.WriteLine("Заданная цифра не трехзначная!");
}
catch
{
    Console.WriteLine("Надо вводить именно целые числа!");
}