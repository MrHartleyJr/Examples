Console.Write("Input username: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("УРАААА");
    Console.WriteLine(username);
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}