namespace Telepathy;

[Token(Token = "0x2000004")]
internal class ClientConnectionState : ConnectionState
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000006")]
	public Thread receiveThread; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000007")]
	public bool Connecting; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000008")]
	public readonly MagnificentReceivePipe receivePipe; //Field offset: 0x38

	[Token(Token = "0x17000001")]
	public bool Connected
	{
		[Address(RVA = "0x18017D0", Offset = "0x18009D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000003")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x1801720", Offset = "0x1800920", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConnectionState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000004")]
	public ClientConnectionState(int MaxMessageSize) { }

	[Address(RVA = "0x18016C0", Offset = "0x18008C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(MagnificentSendPipe), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public void Dispose() { }

	[Address(RVA = "0x18017D0", Offset = "0x18009D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000003")]
	public bool get_Connected() { }

}

