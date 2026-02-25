namespace System.Net.Sockets;

[Token(Token = "0x2000303")]
internal sealed class SocketAsyncResult : IOAsyncResult
{
	[CompilerGenerated]
	[Token(Token = "0x2000304")]
	private sealed class <>c
	{
		[Token(Token = "0x4000E26")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000E27")]
		public static WaitCallback <>9__27_0; //Field offset: 0x8

		[Address(RVA = "0x17300F0", Offset = "0x172F2F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60013A1")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013A2")]
		public <>c() { }

		[Address(RVA = "0x172CCC0", Offset = "0x172BEC0", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60013A3")]
		internal void <Complete>b__27_0(object state) { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E14")]
	public Socket socket; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E15")]
	public SocketOperation operation; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E16")]
	private Exception DelayedException; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E17")]
	public EndPoint EndPoint; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E18")]
	public Memory<Byte> Buffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E19")]
	public int Offset; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000E1A")]
	public int Size; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000E1B")]
	public SocketFlags SockFlags; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000E1C")]
	public Socket AcceptSocket; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000E1D")]
	public IPAddress[] Addresses; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000E1E")]
	public int Port; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000E1F")]
	public IList<ArraySegment`1<Byte>> Buffers; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000E20")]
	public bool ReuseSocket; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000E21")]
	public int CurrentAddress; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000E22")]
	public Socket AcceptedSocket; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000E23")]
	public int Total; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000E24")]
	internal int error; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000E25")]
	public int EndCalled; //Field offset: 0xA8

	[Token(Token = "0x1700041C")]
	public SocketError ErrorCode
	{
		[Address(RVA = "0x171D300", Offset = "0x171C500", Length = "0x83")]
		[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001397")]
		 get { } //Length: 131
	}

	[Token(Token = "0x1700041B")]
	public IntPtr Handle
	{
		[Address(RVA = "0x171D390", Offset = "0x171C590", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001393")]
		 get { } //Length: 45
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001394")]
	public SocketAsyncResult() { }

	[Address(RVA = "0x171D2B0", Offset = "0x171C4B0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001396")]
	public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	[Address(RVA = "0x171CD90", Offset = "0x171BF90", Length = "0xA5")]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(IPEndPoint&)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(EndPoint&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_13", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&), typeof(Int32&), typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001398")]
	public void CheckIfThrowDelayedException() { }

	[Address(RVA = "0x171CF50", Offset = "0x171C150", Length = "0x1B8")]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "CompleteDisposed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendToCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<IPAddress[]>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_14", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(IOAsyncResult), Member = "set_IsCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600139A")]
	public void Complete() { }

	[Address(RVA = "0x171CE50", Offset = "0x171C050", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Token(Token = "0x600139B")]
	public void Complete(bool synch) { }

	[Address(RVA = "0x171CF10", Offset = "0x171C110", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Token(Token = "0x600139C")]
	public void Complete(int total) { }

	[Address(RVA = "0x171CE90", Offset = "0x171C090", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Token(Token = "0x600139D")]
	public void Complete(Exception e, bool synch) { }

	[Address(RVA = "0x171CE60", Offset = "0x171C060", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Token(Token = "0x600139E")]
	public void Complete(Exception e) { }

	[Address(RVA = "0x171CF20", Offset = "0x171C120", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600139F")]
	public void Complete(Socket s) { }

	[Address(RVA = "0x171CED0", Offset = "0x171C0D0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Token(Token = "0x60013A0")]
	public void Complete(Socket s, int total) { }

	[Address(RVA = "0x171CE40", Offset = "0x171C040", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Token(Token = "0x6001399")]
	internal virtual void CompleteDisposed() { }

	[Address(RVA = "0x171D300", Offset = "0x171C500", Length = "0x83")]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001397")]
	public SocketError get_ErrorCode() { }

	[Address(RVA = "0x171D390", Offset = "0x171C590", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001393")]
	public IntPtr get_Handle() { }

	[Address(RVA = "0x171D180", Offset = "0x171C380", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IOAsyncResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Memory`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "System.Memory`1<T>")]
	[Token(Token = "0x6001395")]
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

}

