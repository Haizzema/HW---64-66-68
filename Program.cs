// See https://aka.ms/new-console-template for more information
Console.WriteLine("Наталия Меньшова, ДЗ задачи 64, 66, 68");
Console.WriteLine();
Console.WriteLine("Задача 64"); 
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("БЕЗ РЕКУРСИИ - Введите целое положительное числo: ");
int number = Convert.ToInt32(Console.ReadLine()); 
for (int i=number; i>=1; i=i-1)
{
	if (i==1)
	{	
		Console.Write(i); 
	}
	else
	{
		Console.Write(i+", ");
	}
}
Console.ReadLine();
// Метод РЕКУРСИЯ -- печать строки
Console.Write("РЕКУРСИЯ - Введите ЕЩЕ РАЗ целое положительное числo: ");
int inputNum = Convert.ToInt32(Console.ReadLine()); 
PrintString(inputNum);
//
void PrintString(int num)
{
	  Console.WriteLine(num);
		int a=num-1;
		if (a>0)
		{ 
    	PrintString(a);
    }
}
Console.ReadLine();
//
//Console.WriteLine("Hello, Наталия!");
Console.WriteLine();
Console.WriteLine("Задача 66"); 
//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите через пробел два целых числа: ");
string inputString = Console.ReadLine();
//  Проверка на ошибочность ввода \ пока еще не сделано: 
// - ввод более ДВУХ чисел 
// - ввод менее ДВУХ чисел
// - ввод чисел через запятую
// - отсутствие ввода чисел вообще
string[] matrixSize = inputString.Split(" ");
int number1 = Convert.ToInt32(matrixSize[0]);
int number2 = Convert.ToInt32(matrixSize[1]);
SumNumbers(number1,number2);
void SumNumbers(int a, int b)
{
	if (b>a)
	{
	  int sum=0;
	  for (int i = a; i <=b; i++)
	  {
	    sum=sum+i;
    }  	 
    Console.Write("Cумма натуральных элементов в промежутке между этими числами: ");
		Console.WriteLine(sum);
	}
	else
	{
     Console.WriteLine("Ошибочный ввод чисел!");
	}
}
Console.ReadLine();
//
// Console.WriteLine("Ага, World!");
Console.WriteLine();
Console.WriteLine("Задача 68"); 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Задаем пару неотрицательных числа вручную: 
uint m=3;
uint n=2;
Console.Write("m = "+m+" n = "+n+" -> A(m,n) = ");
// функция Аккермана:
//   if(n=0)          A(m,n)=m1;
//   if (n!=0 && m=0) A(m,n)=A(n-1,1);
//   if (n>0, m>0)    A(n-1, A(n, m-1));
static uint AkkermanFunction(uint n, uint m)
{
  if (n == 0)
	{
    return m + 1;
  }
	else
  {
    if ((n != 0) && (m == 0))
    {
			return AkkermanFunction(n - 1, 1);
		}
    else
		{ 
      return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
		}	
  }
}
uint c=AkkermanFunction(m,n);
Console.WriteLine(c);
Console.ReadLine();

