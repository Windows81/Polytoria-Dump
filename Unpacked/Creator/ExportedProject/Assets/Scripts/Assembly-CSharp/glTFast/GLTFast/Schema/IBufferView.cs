namespace GLTFast.Schema;

[Token(Token = "0x2000097")]
public interface IBufferView
{

	[Token(Token = "0x17000043")]
	public int Buffer
	{
		[Token(Token = "0x60001DF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000045")]
	public int ByteLength
	{
		[Token(Token = "0x60001E1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000044")]
	public int ByteOffset
	{
		[Token(Token = "0x60001E0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60001DF")]
	public int get_Buffer() { }

	[Token(Token = "0x60001E1")]
	public int get_ByteLength() { }

	[Token(Token = "0x60001E0")]
	public int get_ByteOffset() { }

}

