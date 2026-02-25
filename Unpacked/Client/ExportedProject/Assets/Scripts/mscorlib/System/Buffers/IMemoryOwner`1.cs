namespace System.Buffers;

[Token(Token = "0x200060C")]
public interface IMemoryOwner : IDisposable
{

	[Token(Token = "0x170006E8")]
	public Memory<T> Memory
	{
		[Token(Token = "0x6002C4E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002C4E")]
	public Memory<T> get_Memory() { }

}

