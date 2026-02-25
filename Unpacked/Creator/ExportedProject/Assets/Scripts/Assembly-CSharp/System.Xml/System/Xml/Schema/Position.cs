namespace System.Xml.Schema;

[Token(Token = "0x20000D1")]
internal struct Position
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000475")]
	public int symbol; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000476")]
	public object particle; //Field offset: 0x8

	[Address(RVA = "0x880C00", Offset = "0x87FE00", Length = "0x12")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000892")]
	public Position(int symbol, object particle) { }

}

