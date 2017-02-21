using System;

namespace terminalHiLo
{
	class terminalHiLo
	{

		public static void Main(string[] args)
		{
			//Set up variables
			int score = 0;
			int newNum;
			int num = 50;
			string guess;
			bool correct = true;

			Console.WriteLine("The first number is 50. You must guess if the next will be higher or lower.");


			while(correct)
			{

				Console.WriteLine("Please enter your guess: ");
				
				//Read guesses
				guess = Console.ReadLine();
				while((guess != "hi") && (guess != "lo"))
				{
					Console.WriteLine("That's not a valid guess :(");
					guess = Console.ReadLine();
				}

				//Generate random number
				Random rnd = new Random();
				newNum = rnd.Next(100);


				//Check the guesses
				if(newNum >  num && guess == "hi")
				{
					correct = true;
					Console.WriteLine("Correct!");
					Console.WriteLine("The number was: " + newNum);
					score ++;
				}

				else if(newNum < num && guess == "lo")
				{
					correct = true;
					Console.WriteLine("Correct!");
					Console.WriteLine("The number was: " + newNum);
					score ++;

				}


				else
				{
					correct = false;
					Console.WriteLine("Incorrect!");
					Console.WriteLine("The number was: " + newNum);
				}
				

				num = newNum;


			}

			//Display their score
			Console.WriteLine("Your score was: " + score);

		}


	}

}
