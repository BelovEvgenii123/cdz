// Задана последовательность натуральных чисел, завершающаяся числом 0. 
//Требуется определить значение второго по величине элемента в этой последовательности,
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
Console.Clear();
Console.WriteLine("Напишите число");
int a = int.Parse(Console.ReadLine());
int max1=-1;
int max2=-2;
while (a!=0)
{
   if (a>max1)
   {
    max2=max1;
   max1=a;
   }
   else
   {
   max2=a;
   }
   a = int.Parse(Console.ReadLine());
}
Console.WriteLine("End");
Console.Write(max2);

 