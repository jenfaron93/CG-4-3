using System;
using System.Linq;

namespace Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
				int counter = 0;
				Console.WriteLine("Please enter up to 30 names: "); //asks the user for 30 names
				string[] names = new string[30]; //declares an array with a size of 30

				for (int x = 0; x < names.Length; x++)
				{//setting a loop that goes from 1-30
					names[x] = Console.ReadLine(); //each time the loop runs, the user input will be added the array ind

					if (names[x] == "") //if user enters nothing, then break the loop
					{
						break;
					}
					counter++;
				}
			
			
				Random ran = new Random(); //creating a random object named 'ran'

				string winner = names[ran.Next(0, counter)]; //assigning a random array element to winner with a min of 0 and a max of the user's input

				Console.WriteLine($"\nThe winner is {winner}."); //displaying the winner variable
				Console.WriteLine("\nThe other candidates are: ");
		
				 foreach(string name in names){ //looping through the names array
					if (name == winner) //if the winner or null or blank comes up, skip writing it out
						continue;
					else if (name == null)
						continue;
					else if (name == "")
						continue;
					else //otherwise, write the rest out
						Console.WriteLine(name); 
			}

				Console.ReadLine();

        }
    }
}
