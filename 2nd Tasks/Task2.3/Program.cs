bool Polindrom(int num)
{
    int cnt =1000, ans = 0 , temp = num;
    while (temp > 0)
    {
        ans += (temp % 10) * cnt;
        cnt /= 10;
        temp /= 10;
    }
    return num == ans;
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