// See https://aka.ms/new-console-template for more information
Console.Write("Enter X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

int r = 5;

if((X*X) + (Y*Y) <= r*r){
    Console.WriteLine("The number is within the circle");
}

else{
    Console.WriteLine("The number is not within circle ");
}




