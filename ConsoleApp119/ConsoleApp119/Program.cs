// define data source
int[] scores = [4, 90, 340];

// specify search query
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 5
    select score;

 //execute query
 foreach (int i in scoreQuery)
    Console.WriteLine(i + " ");
