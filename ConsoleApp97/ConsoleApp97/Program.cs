// specify data source
int[] scores = [5, 45, 70, 90];

// define query expression
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// execute query
foreach (var i in scoreQuery)
    Console.Write(i + " ");
