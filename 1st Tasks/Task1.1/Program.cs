Console.WriteLine("Please enter a 4 digit number: ");
String input = Console.ReadLine();
int num;
int.TryParse(input, out num);
if ((num % 3 == 0 || num % 7 == 0) && num>=1000 && num<=9999)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}