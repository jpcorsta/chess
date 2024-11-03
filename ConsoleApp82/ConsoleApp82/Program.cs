
    var numberToGuess = new Random().Next(1, 10);
        
    Console.WriteLine("Enter number");

    while(true)
    {

        var num = Convert.ToInt32(Console.ReadLine());

        if(num == numberToGuess)
            Console.WriteLine("indeed");
        else if(num > numberToGuess)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine('<');
                Console.ResetColor();
            }
        else if(num < numberToGuess)
            Console.WriteLine('>');
    }

