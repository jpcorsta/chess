using System;
using System.Collections.Concurrent;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.IOStrea

class Program
{
	static async Task Main()
	{
		var c = Channel.CreateUnBounded<int>(new UnboundedChannelOptions { });

		_ = Task.Run(async delegate
		{
			for (int i = 0; i < 10; i++) 
			{
				await Task.Delay(100);
				await c.Writer.WriteAsync(i);
			}
			c.Writer.Complete();
		});

		while (await c.Reader.WaitToReadAsync()) 
		{
            Console.WriteLine(await c.Reader.ReadAsync());
		}

		//await foreach (int item in c.Reader.ReadAllAsync()) 
		//{
  //          Console.WriteLine(item);
		//}

        Console.WriteLine("done");
	}
}