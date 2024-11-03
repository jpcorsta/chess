// specify data source
int[] scores = [3, 50, 70, 90];

// define query expressiom
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 30
    select score;

// execute query
foreach (var i in scoreQuery)
    Console.Write(i + " ");
