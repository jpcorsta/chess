// set data source
int[] scores = [3, 70, 900];

// define query expression
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 50
    select score;

// execute query
foreach (var i in scoreQuery)
    Console.Write(i + " ");



