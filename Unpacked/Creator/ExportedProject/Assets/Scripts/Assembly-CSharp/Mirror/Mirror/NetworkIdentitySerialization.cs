namespace Mirror;

[Token(Token = "0x200004C")]
public struct NetworkIdentitySerialization
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F0")]
	public int tick; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000F1")]
	public NetworkWriter ownerWriter; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F2")]
	public NetworkWriter observersWriter; //Field offset: 0x10

	[Address(RVA = "0x1265EE0", Offset = "0x12650E0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001E5")]
	public void ResetWriters() { }

}

