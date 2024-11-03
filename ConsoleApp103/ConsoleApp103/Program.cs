// Specify date source
int[] scores = [4, 50, 70,];

// define query expression
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 4
    select score;

// execute query
foreach (var i in scoreQuery)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(i);
    Console.ResetColor();
}
