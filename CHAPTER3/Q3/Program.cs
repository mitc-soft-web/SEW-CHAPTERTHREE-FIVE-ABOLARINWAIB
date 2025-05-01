// See https://aka.ms/new-console-template for more information
Console.Write("Enter Digit:");
int Digit = Convert.ToInt32(Console.ReadLine());

int temp = Digit/100;
int Thirddigit =  temp % 10;

if(Thirddigit == 7){
    Console.WriteLine("The third digit is 7");
}

else{
    Console.WriteLine("The third digit is not 7");
}