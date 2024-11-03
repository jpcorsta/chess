// specify data source
int[] scores = [4, 70, 90];

// define query expressiom
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 0
    select score;

// execute Query
foreach (int i in scoreQuery)
    Console.WriteLine(i + " ");


