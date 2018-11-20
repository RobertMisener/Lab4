using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab4
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//2) The four basic types of counter controlled repitition
			// 1) A control variable
			// 2) the initial value
			// 3) the increment (or decrement by which the control variable 
			// is modified each timethrough the loop (also known as each iteration the loop)
			// 4) the loop-continuation condition that determins whether to coninue looping
			//3) //while statements will continue until the condition of while loop is met. A food loop, like a while loop,
			//continues to go until a condition is met, but the condition itself is either incremented or incrmeented with 
			//each pass through the loop. A for loop in almost all cases must eventually end, but a while loop does not have to
			//4 you want to use a do while loop when the sequence must execute at least one once, regardless of whether or not the condition is initially met
			//the 'do' part of the do-while loop is what does this. A while loop on there other hand may or may not execute, depending on whether the condition
			//is met, there is a chance it will not even execute, assuming condition is already met

			//5
			for (int ii = 1; ii <= 101; ii++)
			{
				if ((ii % 2) == 0)
				{
					Console.WriteLine("it's even");
				}
				else
				{
					Console.WriteLine("it's odd");
				}
			}

			//6
			Console.WriteLine("Please enter a temperature");
			int temp = Convert.ToInt32(Console.ReadLine());

			if (temp < 10)
			{
				Console.WriteLine("Polar Bear");
			}
			else if (temp < 20)
			{
				Console.WriteLine("Penguin");
			}
			else if (temp < 40)
			{
				Console.WriteLine("Moose");
			}
			else if (temp < 50)
			{
				Console.WriteLine("Reindeer");
			}
			else if (temp < 60)
			{
				Console.WriteLine("Deer");
			}
			else if (temp < 70)
			{
				Console.WriteLine("Turtle");
			}
			else if (temp < 90)
			{
				Console.WriteLine("Lion");
			}
			else
			{
				Console.WriteLine("Bug");
			}

			//7 it is missing a an increment to the controll variable
			int i = 10;
			while (i < 21)
			{
				Console.WriteLine(i);
				i++;
			}

			//8 No brackets.

			for (int ii = 0; ii < 101; ii++) {
				Console.WriteLine(ii);
				Console.WriteLine("********");
				}


			Console.ReadLine();


		}
	}
}
