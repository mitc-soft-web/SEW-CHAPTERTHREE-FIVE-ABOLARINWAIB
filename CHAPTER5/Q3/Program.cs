// See https://aka.ms/new-console-template for more information
Console.Write("Enter firstNumber:");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter secondNumber:");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter secondNumber:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNum;

if(secondNum > max && secondNum > thirdNumber ){
    max = secondNum;
}
else
{
    if(thirdNumber > max && thirdNumber > secondNum ){
        max = thirdNumber;
    }
}
Console.WriteLine($"The Maximum Value = {max}" );
