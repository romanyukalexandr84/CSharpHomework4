double stepen(double osn, int pok)
{
    double znach = 1.0;
    for (int i = 0; i < pok; i++)
    {
        znach = znach * osn;
    }
    if (pok >= 0)
        return znach;
    else
    {
        for (int i = 0; i > pok; i--)
        {
            znach = znach * osn;
        }
        return (1 / znach);
    }
}

Console.WriteLine("Введите основание степени");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите показатель степени (целое число)");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число в степени = " + Math.Round((stepen(a, b)), 2));
