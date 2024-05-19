// Specify the data source.
int[] scores = [97, 92, 81, 60,100,85,94];


// Define the query expression.
IEnumerable<string> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select $"The score is {score}";

Console.WriteLine(scoreQuery.Count());



// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i);
}

// Output: 97 92 81