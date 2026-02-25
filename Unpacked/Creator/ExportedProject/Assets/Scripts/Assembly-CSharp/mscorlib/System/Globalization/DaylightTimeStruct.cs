namespace System.Globalization;

[IsReadOnly]
[Token(Token = "0x200053D")]
internal struct DaylightTimeStruct
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015A9")]
	public readonly DateTime Start; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40015AA")]
	public readonly DateTime End; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015AB")]
	public readonly TimeSpan Delta; //Field offset: 0x10

	[Address(RVA = "0x12A5680", Offset = "0x12A4880", Length = "0xC")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002609")]
	public DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta) { }

}

