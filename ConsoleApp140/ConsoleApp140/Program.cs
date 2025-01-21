	int numberToGuess = new Random().Next(8, 17);

	while (true)
	{
		Console.WriteLine("Enter num");

		int num = Convert.ToInt16(Console.ReadLine());

		if(num == numberToGuess)
			Console.WriteLine("ok");
			else if(num < numberToGuess)
			Console.WriteLine("lo");
			else if(num > numberToGuess)
			Console.WriteLine("hi");

	}

