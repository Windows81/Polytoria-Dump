namespace System;

[Token(Token = "0x20000F3")]
public interface IAsyncResult
{

	[Token(Token = "0x1700008A")]
	public object AsyncState
	{
		[Token(Token = "0x600078E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000089")]
	public WaitHandle AsyncWaitHandle
	{
		[Token(Token = "0x600078D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700008B")]
	public bool CompletedSynchronously
	{
		[Token(Token = "0x600078F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000088")]
	public bool IsCompleted
	{
		[Token(Token = "0x600078C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600078E")]
	public object get_AsyncState() { }

	[Token(Token = "0x600078D")]
	public WaitHandle get_AsyncWaitHandle() { }

	[Token(Token = "0x600078F")]
	public bool get_CompletedSynchronously() { }

	[Token(Token = "0x600078C")]
	public bool get_IsCompleted() { }

}

