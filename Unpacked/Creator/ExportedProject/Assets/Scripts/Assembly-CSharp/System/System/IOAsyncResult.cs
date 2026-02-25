namespace System;

[Token(Token = "0x20000D3")]
internal abstract class IOAsyncResult : IAsyncResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400033D")]
	private AsyncCallback async_callback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400033E")]
	private object async_state; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400033F")]
	private ManualResetEvent wait_handle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000340")]
	private bool completed_synchronously; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000341")]
	private bool completed; //Field offset: 0x29

	[Token(Token = "0x170000BB")]
	public AsyncCallback AsyncCallback
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600044E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000BC")]
	public override object AsyncState
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600044F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000BD")]
	public override WaitHandle AsyncWaitHandle
	{
		[Address(RVA = "0x17562F0", Offset = "0x17554F0", Length = "0xEB")]
		[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(EndPoint&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(IPEndPoint&)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_13", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&), typeof(Int32&), typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000450")]
		 get { } //Length: 235
	}

	[Token(Token = "0x170000BE")]
	public override bool CompletedSynchronously
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000451")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000452")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000BF")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000453")]
		 get { } //Length: 5
		[Address(RVA = "0x17563E0", Offset = "0x17555E0", Length = "0xA0")]
		[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6000454")]
		 set { } //Length: 160
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044B")]
	protected IOAsyncResult() { }

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044D")]
	protected IOAsyncResult(AsyncCallback async_callback, object async_state) { }

	[Token(Token = "0x6000455")]
	internal abstract void CompleteDisposed() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044E")]
	public AsyncCallback get_AsyncCallback() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600044F")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x17562F0", Offset = "0x17554F0", Length = "0xEB")]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&), typeof(Int32&), typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_13", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(IPEndPoint&)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(EndPoint&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000450")]
	public override WaitHandle get_AsyncWaitHandle() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000451")]
	public override bool get_CompletedSynchronously() { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000453")]
	public override bool get_IsCompleted() { }

	[Address(RVA = "0x17562A0", Offset = "0x17554A0", Length = "0x50")]
	[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs), typeof(AsyncCallback), typeof(object), typeof(SocketOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(AsyncCallback), typeof(object), typeof(SocketOperation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[Token(Token = "0x600044C")]
	protected void Init(AsyncCallback async_callback, object async_state) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000452")]
	protected void set_CompletedSynchronously(bool value) { }

	[Address(RVA = "0x17563E0", Offset = "0x17555E0", Length = "0xA0")]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000454")]
	protected void set_IsCompleted(bool value) { }

}

