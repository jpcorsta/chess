using HelloWorldLibrary.BusinessLogic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace HelloWorldTest.BusinessLogic;

public class MessagesTest
{
	[Fact]
	public void Greeting_InEnglish()
	{
		ILogger<Messages> logger = new NullLogger<Messages>();
		Messages messages = new(logger);

		string expected = "Hello World";
		string actual = messages.Greeting(language: "en");

		Assert.Equal(expected, actual);
	}

	[Fact]
	public void Greeting_InSpanish()
	{
		ILogger<Messages> logger = new NullLogger<Messages>();
		Messages messages = new(logger);

		string expected = "Hola Mundo";
		string actual = messages.Greeting(language: "es");

		Assert.Equal(expected, actual);
	}
	
	[Fact]
	public void Greeting_Invalid()
	{
		ILogger<Messages> logger = new NullLogger<Messages>();
		Messages messages = new(logger);

		Assert.Throws<InvalidOperationException>(
			() => messages.Greeting(language: "fr")
			);
	}
}
