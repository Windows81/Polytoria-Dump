namespace Mirror;

[Token(Token = "0x2000010")]
internal struct ThreadEvent
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007C")]
	public ThreadEventType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400007D")]
	public object param; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007E")]
	public Nullable<Int32> connectionId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007F")]
	public Nullable<Int32> channelId; //Field offset: 0x18

	[Address(RVA = "0x127FD30", Offset = "0x127EF30", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600009B")]
	public ThreadEvent(ThreadEventType type, object param, Nullable<Int32> connectionId = null, Nullable<Int32> channelId = null) { }

}

