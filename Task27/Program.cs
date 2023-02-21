int SumDigit (int digit)
{
string temp = Convert.ToString (digit);
int leng = temp.Length;

int ost = 0;
int sum = 0;

for (int i=0; i < leng; i++)
{
    ost = digit % 10;
    digit = digit / 10;
    sum = sum + ost;
}
return sum;
}

Console.WriteLine ("Введите целое положительное число");
int chislo = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Сумма цифр в числе = "+SumDigit (chislo));