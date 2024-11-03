// specify data source
int[] scores = [4, 43, 50, 80];

// define query expressiom
IEnumerable<int> scoreQuery =
    from score  in scores
    where score > 20
    select score;

// execute query
foreach (var i in scoreQuery)
    Console.WriteLine(i + " ");