namespace Mirror.SimpleWeb;

[Token(Token = "0x2000017")]
public struct Message
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000055")]
	public readonly int connId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000056")]
	public readonly EventType type; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000057")]
	public readonly ArrayBuffer data; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000058")]
	public readonly Exception exception; //Field offset: 0x10

	[Address(RVA = "0x1557810", Offset = "0x1556A10", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000061")]
	public Message(EventType type) { }

	[Address(RVA = "0x1557850", Offset = "0x1556A50", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000062")]
	public Message(ArrayBuffer data) { }

	[Address(RVA = "0x1557890", Offset = "0x1556A90", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000063")]
	public Message(Exception exception) { }

	[Address(RVA = "0x1557870", Offset = "0x1556A70", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000064")]
	public Message(int connId, EventType type) { }

	[Address(RVA = "0x15578B0", Offset = "0x1556AB0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000065")]
	public Message(int connId, ArrayBuffer data) { }

	[Address(RVA = "0x1557820", Offset = "0x1556A20", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000066")]
	public Message(int connId, Exception exception) { }

}

