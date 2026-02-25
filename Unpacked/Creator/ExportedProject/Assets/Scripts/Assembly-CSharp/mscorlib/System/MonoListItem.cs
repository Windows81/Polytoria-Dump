namespace System;

[Token(Token = "0x20001B9")]
internal sealed class MonoListItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000727")]
	private MonoListItem next; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000728")]
	private object data; //Field offset: 0x18

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F8B")]
	public MonoListItem() { }

}

