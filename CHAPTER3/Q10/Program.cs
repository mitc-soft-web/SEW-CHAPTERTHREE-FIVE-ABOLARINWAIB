// See https://aka.ms/new-console-template for more information
Console.Write("Enter 4digitNumber:");
int Num = Convert.ToInt32(Console.ReadLine());
int a = Num/1000;

int tempB = Num/100;
int b = tempB % 10;
Console.WriteLine()
int c = Num/10 % 10;

int d = Num % 10;
int sum = a+b+c+d;
System.Console.WriteLine(sum);
System.Console.WriteLine($"{d}{c}{b}{a}");
Console.WriteLine($"{d}{a}{b}{c}");
Console.WriteLine($"{a}{c}{b}{d}");