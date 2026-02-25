namespace System.Linq.Expressions;

[Token(Token = "0x2000077")]
internal interface IParameterProvider
{

	[Token(Token = "0x17000068")]
	public int ParameterCount
	{
		[Token(Token = "0x6000338")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000338")]
	public int get_ParameterCount() { }

	[Token(Token = "0x6000337")]
	public ParameterExpression GetParameter(int index) { }

}

