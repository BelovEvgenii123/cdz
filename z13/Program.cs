//Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
//НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК

Console.Clear();
Console.WriteLine("Напишите число");
int a = int.Parse(Console.ReadLine());
    if (a <100)
Console.Write("третьей цифры нет");
    while(a >=1000)
{
 a =a/10;
}
int a1 = a%10;
Console.Write(a1);
