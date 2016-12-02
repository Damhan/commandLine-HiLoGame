using System;

namespace terminalHiLo
{
	class terminalHiLo
	{

		public static void Main(string[] args)
		{

			int score = 0;
			int newNum;
			int num = 50;
			string guess;
			bool correct = true;

			Console.WriteLine("The first number is 50. You must guess if the next will be higher or lower.");


			while(correct)
			{

				Console.WriteLine("Please enter your guess: ");
				guess = Console.ReadLine();


				Random rnd = new Random();
				newNum = rnd.Next(100);

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


			Console.WriteLine("Your score was: " + score);

		}


	}

}