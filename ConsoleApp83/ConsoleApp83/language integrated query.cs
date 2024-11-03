// Specify the data source.
int[] scores = [97, 50, 99, 170];

// Define the query expression
IEnumerable<int> scoreQuery = 
    from score in scores 
    where score > 80
    select score;

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.WriteLine(i + " ");;
}

// Output : 