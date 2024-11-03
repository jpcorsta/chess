using System.Diagnostics;

//...
void StopwatchUsingMethod()
{
  //A: Setup and stuff you don't want timed
  var timer = new Stopwatch();
  timer.Start();

  //B: Run stuff you want timed
  timer.Stop();

  TimeSpan timeTaken = timer.Elapsed;
  string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff"); 

  Console.ReadKey();
}