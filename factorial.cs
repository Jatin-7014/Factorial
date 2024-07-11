using System;
class Factorial
{ 
	public static void Main(String [] args){
	int number;
	int factorial=1;
	Console.WriteLine("Enter a number:");
	number=Convert.ToInt32(Console.ReadLine());

	for(int i=number;i>=1;i--){
		factorial*=i;
	}
	
	Console.WriteLine("The factorial of "+number+" is "+factorial);
    }
}