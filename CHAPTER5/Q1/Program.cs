// See https://aka.ms/new-console-template for more information
// Console.Write("Enter firstDigit");
// int firstDigit = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter secondDigit");
// int secondDigit = Convert.ToInt32(Console.ReadLine());

int firstDigit = 2;
int secondDigit = 4;


if(firstDigit > secondDigit)
{
    int tempDigit = firstDigit;
    firstDigit = secondDigit;
    secondDigit = tempDigit ;
    
    Console.WriteLine($" The firstDigit is  {firstDigit} and The secondDigitDigit is  {secondDigit}");
}


else{
    Console.WriteLine("The firstDigit is not greater than the seconDigit");
    }