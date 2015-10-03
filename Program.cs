using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			#region Loops
			Console.WriteLine("Here we demonstrate a for loop");
			for (int counter = 0; counter < 5; counter++)
			{
				Console.WriteLine(counter);
			}
			Console.WriteLine("~~~~Oh boy! You can count!~~~~");
			Console.WriteLine("Next, we demonstrate a foreach loop");
			int[] arrInts =  new int[] {3,5,7,9};
			foreach (int item in arrInts)
			{
				Console.WriteLine(item);
				Console.WriteLine("");
				Console.WriteLine("Notice that the array's output looks like a list of numbers");
			}
			Console.WriteLine(" ");
			Console.WriteLine("50 points if you can guess why the above sentence was repeated 4 times");
			Console.WriteLine("If you guessed that it was part of the foreach loop body");
			Console.WriteLine("that is executed for each element in the array, you win 50 points!");
			Console.WriteLine("");
			Console.WriteLine("Now we'll do a while loop");

			int sentinel = 0;
			while (sentinel < 5)
			{
				Console.WriteLine(sentinel);
				sentinel++;
			}

			Console.WriteLine("Next we demonstrate the do-while loop");
			Console.WriteLine("It executes the code inside the do-block if conditions are met");
			Console.WriteLine("by evaluating the condition at the end of the loop.");
			Console.WriteLine("As long as the condition at the end is met,");
			Console.WriteLine("the code inside the do-while loop is executed.");
			int sentinel2 = 5;
			do
			{
				Console.WriteLine(sentinel2);
				sentinel2++;
			} while (sentinel2 < 10);

			#endregion

			#region Decision Structures
			//if statement
			bool result = true;
			if (result)
			{
				Console.WriteLine("Result was true");
			}
			else
			{
				Console.WriteLine("Result was false");
			}

			int value = 2;
			if (value == 0)
			{
				Console.WriteLine("Value is 0");
			}
			else if (value == 1)
			{
				Console.WriteLine("Value is 1");
			}
			else
			{
				Console.WriteLine("Value is something else");
			}

			//switch and case
			int val = 3;
			switch (val)
			{
			case 0:
				Console.WriteLine("Value is 0");
				break;

			case 1:
				Console.WriteLine("Value is 1");
				break;

			default:
				Console.WriteLine("Value is NaN");
				break;
			}
				
				
			#endregion
		}
	
	}


}
