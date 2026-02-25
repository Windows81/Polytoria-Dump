namespace Mirror;

[Token(Token = "0x200000E")]
internal struct ClientMainEvent
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000073")]
	public ClientMainEventType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000074")]
	public object param; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000075")]
	public Nullable<Int32> channelId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000076")]
	public Nullable<TransportError> error; //Field offset: 0x18

	[Address(RVA = "0x1270070", Offset = "0x126F270", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000099")]
	public ClientMainEvent(ClientMainEventType type, object param, Nullable<Int32> channelId = null, Nullable<TransportError> error = null) { }

}

