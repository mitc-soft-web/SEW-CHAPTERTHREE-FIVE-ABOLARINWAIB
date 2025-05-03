// See https://aka.ms/new-console-template for more information
Console.Write("Enter firstNum:");
int firstNum = Convert.ToInt64(Console.ReadLine());
Console.Write("Enter secondNum:");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter thirdNum:");
int thirdNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter forthNum:");
int forthNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fifthNum:");
int fifthNum = Convert.ToInt32(Console.ReadLine());

long sum = firstNum + secondNum + thirdNum + forthNum + fifthNum;
Console.WriteLine(sum);