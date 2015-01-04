// -------------------------------------------------------------------	
// Department of Electrical and Computer Engineering
// University of Waterloo
//
// Student Name:     PRAGASH SIVASUNDARAM
// Userid:           psivasun
//
// Assignment:       PROGRAMMING ASSIGNMENT 2
// Submission Date:  OCTOBER 7TH 2014
// 
// I declare that, other than the acknowledgements listed below, 
// this program is my original work.
//
// Acknowledgements:
// NONE
// -------------------------------------------------------------------

using System;

public class BinaryConverter
{
	public static void Main()
	{
		Console.Write("Enter an unsigned integer number: ");
		string input =(Console.ReadLine());		    		// Stores original copy of input as a string 
		uint number = 0; 									// Variable declared to store the input(if tryParse method returns true)
		bool inRange = uint.TryParse(input, out number);		// False if input is not an positive integer
				
		if (!inRange)										// Checks to see if number entered can be parsed into uint
		{
			Console.WriteLine("Input Error: User input must be an integer");		
			Console.WriteLine("Program will now terminate.");
		}
		else 
		{		
			Console.Write("The binary encoding of {0} is ",number);
			int nBits =(int) Math.Floor(Math.Log(number,2)+1); // Calculates the number of bits using floor(Log2(num)+1)
			for (int i = 1; i<=32-nBits; i++)				// Pads the output with 32 - nBits 0s
				Console.Write('0');
			ToBin((uint)number);						    /* Calls ToBin (void method) to convert to binary, 
															   casts integer to unsigned integer*/
		}
	}
	
	public static void ToBin(uint num)
	{
		if (num == 1 || num == 0)							// --- BASE CASE
			Console.Write(num);								// If num is 1 or 0, then exit recursion after printing the number
			
		else												// --- INDUCTION
		{	
			ToBin(num/2);									// 1. Change half of Number to Binary
			Console.Write(num%2);							// 2. Change Number to Binary
		}
	}
}	