namespace System.Globalization;

[Token(Token = "0x200053E")]
internal struct HebrewNumberParsingContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015AC")]
	internal HS state; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40015AD")]
	internal int result; //Field offset: 0x4

	[Address(RVA = "0x13F5F40", Offset = "0x13F5140", Length = "0x7")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchHebrewDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "TryParseHebrewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(Boolean&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x600260A")]
	public HebrewNumberParsingContext(int result) { }

}

