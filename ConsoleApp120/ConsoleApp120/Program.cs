var numberToGuess = new Random().Next(6, 19);

while (true)
{
    Console.WriteLine("Enter number");

    var num = Convert.ToInt32(Console.ReadLine());

    if (num == numberToGuess)
        Console.WriteLine("indeed");
    else if (num > numberToGuess)
        Console.WriteLine("hi");
    else if (num < numberToGuess)
        Console.WriteLine("low");

}