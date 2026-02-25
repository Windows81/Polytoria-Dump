namespace System;

[Token(Token = "0x200019D")]
internal class MonoTypeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006CC")]
	public string full_name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006CD")]
	public RuntimeConstructorInfo default_ctor; //Field offset: 0x18

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EF9")]
	public MonoTypeInfo() { }

}

