namespace System;

[Token(Token = "0x20001B6")]
internal class MonoAsyncCall
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071C")]
	private object msg; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400071D")]
	private IntPtr cb_method; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400071E")]
	private object cb_target; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400071F")]
	private object state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000720")]
	private object res; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000721")]
	private object out_args; //Field offset: 0x38

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F72")]
	public MonoAsyncCall() { }

}

