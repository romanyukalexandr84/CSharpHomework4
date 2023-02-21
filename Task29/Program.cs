string GetHtml()
{
    string html = String.Empty;
    html = File.ReadAllText(
        @"C:\Users\User\Desktop\Домашние задания\3. Си Шарп\Seminar4\Task29\File.html"
    );
    return html;
}

string final = GetHtml();

string Check()
{
    if ((final.Contains(",")) || (final.Contains(" ")))
    {
        return "это массив";
    }
    else
        return "это не массив";
}

Console.WriteLine(Check());

if ((Check() == "это массив"))
{
    string nov = String.Empty;
    nov = final.Replace(",", "");
    nov = nov.Replace(" ", "");

    int leng = nov.Length;
    int temp = Convert.ToInt32(nov);
    int[] array = new int[leng];
    for (int i = leng - 1; i >= 0; i--)
    {
        array[i] = temp % 10;
        temp = temp / 10;
    }

    Console.Write("[" + array[0] + ", ");
    for (int j = 1; j < leng - 1; j++)
    {
        Console.Write(array[j] + ", ");
    }
    Console.Write(array[leng - 1] + "]");

    Console.WriteLine();
}
else
{
    Console.WriteLine();
}
