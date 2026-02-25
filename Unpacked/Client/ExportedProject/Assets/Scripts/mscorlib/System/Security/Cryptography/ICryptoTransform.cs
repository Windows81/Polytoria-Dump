namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F4")]
public interface ICryptoTransform : IDisposable
{

	[Token(Token = "0x17000275")]
	public bool CanTransformMultipleBlocks
	{
		[Token(Token = "0x60017EA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000273")]
	public int InputBlockSize
	{
		[Token(Token = "0x60017E8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000274")]
	public int OutputBlockSize
	{
		[Token(Token = "0x60017E9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60017EA")]
	public bool get_CanTransformMultipleBlocks() { }

	[Token(Token = "0x60017E8")]
	public int get_InputBlockSize() { }

	[Token(Token = "0x60017E9")]
	public int get_OutputBlockSize() { }

	[Token(Token = "0x60017EB")]
	public int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[Token(Token = "0x60017EC")]
	public Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

