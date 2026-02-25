namespace System;

[Token(Token = "0x20000EB")]
internal struct ParsingInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003B6")]
	internal Calendar calendar; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003B7")]
	internal int dayOfWeek; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40003B8")]
	internal TM timeMark; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003B9")]
	internal bool fUseHour12; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40003BA")]
	internal bool fUseTwoDigitYear; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40003BB")]
	internal bool fAllowInnerWhite; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x40003BC")]
	internal bool fAllowTrailingWhite; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003BD")]
	internal bool fCustomNumberParser; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003BE")]
	internal MatchNumberDelegate parseNumberDelegate; //Field offset: 0x18

	[Address(RVA = "0x14B1E00", Offset = "0x14B1000", Length = "0x9")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600074F")]
	internal void Init() { }

}

