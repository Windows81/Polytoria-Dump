namespace System.Linq.Expressions;

[Token(Token = "0x2000076")]
public interface IArgumentProvider
{

	[Token(Token = "0x17000067")]
	public int ArgumentCount
	{
		[Token(Token = "0x6000336")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000336")]
	public int get_ArgumentCount() { }

	[Token(Token = "0x6000335")]
	public Expression GetArgument(int index) { }

}

