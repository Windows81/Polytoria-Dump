namespace System;

[Token(Token = "0x20001CC")]
internal interface TypeIdentifier : TypeName, IEquatable<TypeName>
{

	[Token(Token = "0x17000175")]
	public string InternalName
	{
		[Token(Token = "0x6001028")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001028")]
	public string get_InternalName() { }

}

