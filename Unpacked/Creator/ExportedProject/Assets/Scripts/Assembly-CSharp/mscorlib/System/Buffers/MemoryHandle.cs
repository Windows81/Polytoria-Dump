namespace System.Buffers;

[Token(Token = "0x200060E")]
public struct MemoryHandle : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001899")]
	private Void* _pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400189A")]
	private GCHandle _handle; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400189B")]
	private IPinnable _pinnable; //Field offset: 0x10

	[CLSCompliant(False)]
	[Token(Token = "0x170006E9")]
	public Void* Pointer
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C51")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1445B10", Offset = "0x1444D10", Length = "0x17")]
	[CalledBy(Type = typeof(Memory`1), Member = "Pin", ReturnType = typeof(MemoryHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CLSCompliant(False)]
	[Token(Token = "0x6002C50")]
	public MemoryHandle(Void* pointer, GCHandle handle = null, IPinnable pinnable = null) { }

	[Address(RVA = "0x1445AA0", Offset = "0x1444CA0", Length = "0x70")]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IOAsyncResult"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint&", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncResult", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint"}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002C52")]
	public override void Dispose() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C51")]
	public Void* get_Pointer() { }

}

