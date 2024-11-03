// Specify the data source.
int[] scores = [92, 56, 40, 78];

// Define the query expression
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 40
    select score;

// Execute the query
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}
