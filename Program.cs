// ---------------------------------ДЗ к семнару №9--------------------------------------------------------------------------------------------
//Задача №1.Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void PrintNumber(int m, int n)
{
  if (n > m) PrintNumber(m, n-1);
  else  if (m > n) PrintNumber(m, n+1);
  
  Console.Write(n + " ");
}

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumber(m, n);
*/
//Задача №2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void ShowSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Sum of elements = {sum} ");
    return;
  }
  ShowSum(m, n - 1, sum);
}
Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
ShowSum(m, n, temp = 0);
*/
//Задача №3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if( m > 0 )
        if( n > 0)
            return Akkerman(m-1, Akkerman(m, n-1));
        else
            return Akkerman(m-1, 1);
    else
        return n+1;
}
Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Ackerman function = {Akkerman(m, n)}");
*/
