// See https://aka.ms/new-console-template for more information
Console.Write("Enter firstNum:");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter secondNum:");
int secondNum = Convert.ToInt32(Console.ReadLine());

string check = (firstNum > secondNum) 
? "First number is the greater number": "Second number is the the greater number";

Console.WriteLine(check);
