bool Polindrom(int num)
{
    return num.ToString().Reverse().ToArray().SequenceEqual(num.ToString().ToArray());
}

int num;
Console.WriteLine("Please enter a 4 digit number");
String input = Console.ReadLine();
if (int.TryParse(input, out num))
{
    if (num > 999 && num < 10000)
    {
        Console.WriteLine(Polindrom(num));
    }
    else
    {
        Console.WriteLine("False");
    }
}
else
{
    Console.WriteLine("False");
}
