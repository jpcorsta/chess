new Thread(() =>
{
    Console.WriteLine("Starting downloading");
    var webClient = new HttpClient();
    var html = webClient.GetStringAsync("http://www.vw.th");
}).Start();

Console.WriteLine("All done");