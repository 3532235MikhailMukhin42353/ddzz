//Принимает цифру, обозначающую день недели и проверяет, является этот день выходным.
try
{
    Console.WriteLine("Введите число дня недели");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x>0 && x<6) Console.WriteLine("Рабочий день недели");
    else if (x>5 && x<8) Console.WriteLine("Выходной");
    else Console.WriteLine("Некорректная дата");
}
catch
{
    Console.WriteLine("Введите именно число дня недели!");
}