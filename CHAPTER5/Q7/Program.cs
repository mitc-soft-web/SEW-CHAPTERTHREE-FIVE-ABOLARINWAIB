// See https://aka.ms/new-console-template for more information
Console.Write("Enter firstNum:");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter secondNum:");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter thirdNum:");
int thirdNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter forthNum:");
int forthNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fifthNum:");
int fifthNum = Convert.ToInt32(Console.ReadLine());

  if (firstNum < secondNum){
       firstNum = secondNum;
  } 
    if (firstNum < thirdNum){
       firstNum = thirdNum;
    } 
    if (firstNum < forthNum){
      firstNum = forthNum;
    } 
    if (firstNum < fifthNum){
      firstNum = fifthNum;
    } 

    Console.WriteLine($" The biggest number is {firstNum}");

