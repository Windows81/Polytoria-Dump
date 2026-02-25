namespace System;

[Token(Token = "0x20001CB")]
internal interface TypeName : IEquatable<TypeName>
{

	[Token(Token = "0x17000174")]
	public string DisplayName
	{
		[Token(Token = "0x6001027")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001027")]
	public string get_DisplayName() { }

}

