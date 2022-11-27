// Задана последовательность натуральных чисел, завершающаяся числом 0. 
//Требуется определить значение второго по величине элемента в этой последовательности,
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
Console.Clear();
Console.WriteLine("Напишите число");
int a = int.Parse(Console.ReadLine());
int max1=a;
int max2=-1;
while (a!=0)
{
   a = int.Parse(Console.ReadLine()); 
   if (a>max2) 
    max2=a;
  if (a>max1)
  {
    max2=max1;
    max1=a;
  }
}
Console.WriteLine("End");
Console.Write(max2);

 