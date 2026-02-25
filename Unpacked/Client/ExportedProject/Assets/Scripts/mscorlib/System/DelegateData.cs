namespace System;

[Token(Token = "0x20001A5")]
internal sealed class DelegateData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006F8")]
	public Type target_type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006F9")]
	public string method_name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006FA")]
	public bool curried_first_arg; //Field offset: 0x20

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F28")]
	public DelegateData() { }

}

