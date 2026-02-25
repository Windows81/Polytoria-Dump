namespace Mirror;

[Token(Token = "0x200000F")]
internal struct ServerMainEvent
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000077")]
	public ServerMainEventType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000078")]
	public object param; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000079")]
	public Nullable<Int32> connectionId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007A")]
	public Nullable<Int32> channelId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400007B")]
	public Nullable<TransportError> error; //Field offset: 0x20

	[Address(RVA = "0x127DAA0", Offset = "0x127CCA0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600009A")]
	public ServerMainEvent(ServerMainEventType type, object param, Nullable<Int32> connectionId, Nullable<Int32> channelId = null, Nullable<TransportError> error = null) { }

}

