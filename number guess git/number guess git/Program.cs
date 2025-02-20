int numberToGuess = new Random().Next(3, 90);

while (true) 
{
	Console.WriteLine("Enter number");
	 
	int userInput = Convert.ToInt16(Console.ReadLine());

	if (userInput == numberToGuess)
		Console.WriteLine("indeed");
	else if (userInput < numberToGuess)
		Console.WriteLine("low");
	else if (userInput > numberToGuess)
		Console.WriteLine("Hi");
}
