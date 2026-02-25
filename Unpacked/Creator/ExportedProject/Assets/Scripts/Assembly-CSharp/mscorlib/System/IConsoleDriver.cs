namespace System;

[Token(Token = "0x20001B2")]
internal interface IConsoleDriver
{

	[Token(Token = "0x17000161")]
	public ConsoleColor ForegroundColor
	{
		[Token(Token = "0x6000F4F")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000F50")]
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	[Token(Token = "0x6000F51")]
	public void ResetColor() { }

	[Token(Token = "0x6000F4F")]
	public void set_ForegroundColor(ConsoleColor value) { }

}

