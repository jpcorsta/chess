int numberToGuess = new Random().Next(3, 90);

while(true)
{
    Console.WriteLine("Enter number");

    int num = Convert.ToInt32(Console.ReadLine());

    if(num == numberToGuess)
        Console.WriteLine("Indeed");
    else if(num < numberToGuess)
        Console.WriteLine("You guessed ");
    else if(num > numberToGuess)
        Console.WriteLine("Indeed");

}