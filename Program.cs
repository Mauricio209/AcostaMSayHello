//Mauricio Acosta
//10-18-22
// Git Challange Say Hello
Console.Clear();
string replay = "yes";
while (replay == "yes")
{
    Console.WriteLine("What is your name?:");

string myName = Console.ReadLine();

Console.WriteLine("Hello, " + myName);
    Console.WriteLine("Type yes to replay");
replay = Console.ReadLine();
}
