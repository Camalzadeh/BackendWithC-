Console.WriteLine("Please enter a number: ");
String input=Console.ReadLine();
int num;
int.TryParse(input, out num);
Console.WriteLine(num%10);