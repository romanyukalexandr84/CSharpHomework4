int SumDigit (string digit)
{
int leng = digit.Length;
int num = int.Parse(digit);

int ost = 0;
int sum = 0;

for (int i=0; i < leng; i++)
{
    ost = num % 10;
    num = num / 10;
    sum = sum + ost;
}
return sum;
}

Console.WriteLine ("Введите целое положительное число");
string chislo = Console.ReadLine();
Console.WriteLine ("Сумма цифр в числе = "+SumDigit (chislo));