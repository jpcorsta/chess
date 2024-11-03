// specify data source
int[] scores = [30, 80, 90, 130];

// define query expression
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 50
    select score;

// execute query
foreach (var i in scoreQuery)
    Console.Write(i + " ");
