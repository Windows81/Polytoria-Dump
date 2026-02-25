namespace System.Net.Sockets;

[Token(Token = "0x2000302")]
public class SocketAsyncEventArgs : EventArgs, IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DFC")]
	private bool disposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000DFD")]
	internal int in_progress; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DFE")]
	private EndPoint remote_ep; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DFF")]
	private Socket current_socket; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E00")]
	internal SocketAsyncResult socket_async_result; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E01")]
	private Exception <ConnectByNameError>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E02")]
	private Socket <AcceptSocket>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E03")]
	private int <BytesTransferred>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000E04")]
	private bool <DisconnectReuseSocket>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E05")]
	private SocketAsyncOperation <LastOperation>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E06")]
	private IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E07")]
	private SendPacketsElement[] <SendPacketsElements>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000E08")]
	private TransmitFileOptions <SendPacketsFlags>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000E09")]
	private int <SendPacketsSendSize>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000E0A")]
	private SocketError <SocketError>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000E0B")]
	private SocketFlags <SocketFlags>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000E0C")]
	private object <UserToken>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000E0D")]
	private EventHandler<SocketAsyncEventArgs> Completed; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000E0E")]
	private Memory<Byte> _buffer; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000E0F")]
	private int _offset; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000E10")]
	private int _count; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000E11")]
	private bool _bufferIsExplicitArray; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000E12")]
	private IList<ArraySegment`1<Byte>> _bufferList; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000E13")]
	private List<ArraySegment`1<Byte>> _bufferListInternal; //Field offset: 0xB0

	[Token(Token = "0x1700040E")]
	public Socket AcceptSocket
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001377")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001378")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700041A")]
	public IList<ArraySegment`1<Byte>> BufferList
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001391")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700040F")]
	public private int BytesTransferred
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001379")]
		 get { } //Length: 4
		[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600137A")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000419")]
	public int Count
	{
		[Address(RVA = "0x508E90", Offset = "0x508090", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001390")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000416")]
	internal Socket CurrentSocket
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001389")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000410")]
	private SocketAsyncOperation LastOperation
	{
		[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600137B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000417")]
	public Memory<Byte> MemoryBuffer
	{
		[Address(RVA = "0x171CD80", Offset = "0x171BF80", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600138E")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000418")]
	public int Offset
	{
		[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600138F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000411")]
	public EndPoint RemoteEndPoint
	{
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600137C")]
		 set { } //Length: 13
	}

	[MonoTODO("unused property")]
	[Token(Token = "0x17000412")]
	public int SendPacketsSendSize
	{
		[Address(RVA = "0x96AC70", Offset = "0x969E70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600137D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000413")]
	public SocketError SocketError
	{
		[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600137E")]
		 get { } //Length: 4
		[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600137F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000414")]
	public SocketFlags SocketFlags
	{
		[Address(RVA = "0x16BC6C0", Offset = "0x16BB8C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001380")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000415")]
	public object UserToken
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001381")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001382")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x171CCF0", Offset = "0x171BEF0", Length = "0x87")]
	[CalledBy(Type = "System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001384")]
	internal SocketAsyncEventArgs(bool flowExecutionContext) { }

	[Address(RVA = "0x171CC60", Offset = "0x171BE60", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001383")]
	public SocketAsyncEventArgs() { }

	[Address(RVA = "0x171C970", Offset = "0x171BB70", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600138C")]
	internal void Complete_internal() { }

	[Address(RVA = "0x171C9B0", Offset = "0x171BBB0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001387")]
	public override void Dispose() { }

	[Address(RVA = "0x171CA10", Offset = "0x171BC10", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001386")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x171CA20", Offset = "0x171BC20", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001385")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001377")]
	public Socket get_AcceptSocket() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001391")]
	public IList<ArraySegment`1<Byte>> get_BufferList() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001379")]
	public int get_BytesTransferred() { }

	[Address(RVA = "0x508E90", Offset = "0x508090", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001390")]
	public int get_Count() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001389")]
	internal Socket get_CurrentSocket() { }

	[Address(RVA = "0x171CD80", Offset = "0x171BF80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600138E")]
	public Memory<Byte> get_MemoryBuffer() { }

	[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600138F")]
	public int get_Offset() { }

	[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600137E")]
	public SocketError get_SocketError() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001381")]
	public object get_UserToken() { }

	[Address(RVA = "0x171CA60", Offset = "0x171BC60", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600138D")]
	protected override void OnCompleted(SocketAsyncEventArgs e) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001378")]
	public void set_AcceptSocket(Socket value) { }

	[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600137A")]
	private void set_BytesTransferred(int value) { }

	[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600137B")]
	private void set_LastOperation(SocketAsyncOperation value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600137C")]
	public void set_RemoteEndPoint(EndPoint value) { }

	[Address(RVA = "0x96AC70", Offset = "0x969E70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600137D")]
	public void set_SendPacketsSendSize(int value) { }

	[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600137F")]
	public void set_SocketError(SocketError value) { }

	[Address(RVA = "0x16BC6C0", Offset = "0x16BB8C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001380")]
	public void set_SocketFlags(SocketFlags value) { }

	[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001382")]
	public void set_UserToken(object value) { }

	[Address(RVA = "0x171CA90", Offset = "0x171BC90", Length = "0xFA")]
	[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(SocketFlags), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(SocketFlags), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001392")]
	public void SetBuffer(Memory<Byte> buffer) { }

	[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001388")]
	internal void SetBytesTransferred(int value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600138A")]
	internal void SetCurrentSocket(Socket socket) { }

	[Address(RVA = "0x171CB90", Offset = "0x171BD90", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600138B")]
	internal void SetLastOperation(SocketAsyncOperation op) { }

}

