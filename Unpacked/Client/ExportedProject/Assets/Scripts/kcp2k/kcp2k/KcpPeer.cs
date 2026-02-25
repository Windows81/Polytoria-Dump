namespace kcp2k;

[Token(Token = "0x200000D")]
public abstract class KcpPeer
{
	[Token(Token = "0x4000033")]
	public const int DEFAULT_TIMEOUT = 10000; //Field offset: 0x0
	[Token(Token = "0x400003F")]
	public const int METADATA_SIZE = 5; //Field offset: 0x0
	[Token(Token = "0x400003E")]
	public const int COOKIE_HEADER_SIZE = 4; //Field offset: 0x0
	[Token(Token = "0x400003A")]
	public const int PING_INTERVAL = 1000; //Field offset: 0x0
	[Token(Token = "0x400003D")]
	public const int CHANNEL_HEADER_SIZE = 1; //Field offset: 0x0
	[Token(Token = "0x400003C")]
	internal const int QueueDisconnectThreshold = 10000; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000030")]
	internal Kcp kcp; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000031")]
	internal uint cookie; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000032")]
	protected KcpState state; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000034")]
	public int timeout; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000035")]
	private uint lastReceiveTime; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000036")]
	private readonly Stopwatch watch; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000037")]
	private readonly Byte[] kcpMessageBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000038")]
	private readonly Byte[] kcpSendBuffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000039")]
	private readonly Byte[] rawSendBuffer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400003B")]
	private uint lastPingTime; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000040")]
	public readonly int unreliableMax; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000041")]
	public readonly int reliableMax; //Field offset: 0x50

	[Token(Token = "0x17000007")]
	public uint MaxReceiveRate
	{
		[Address(RVA = "0x109E320", Offset = "0x109D520", Length = "0x30")]
		[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetAverageMaxReceiveRate>b__52_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(long))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000026")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000006")]
	public uint MaxSendRate
	{
		[Address(RVA = "0x109E360", Offset = "0x109D560", Length = "0x30")]
		[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetAverageMaxSendRate>b__51_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(long))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000025")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000005")]
	public int ReceiveBufferCount
	{
		[Address(RVA = "0x109E3A0", Offset = "0x109D5A0", Length = "0x48")]
		[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetTotalReceiveBuffer>b__56_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(int))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000021")]
		 get { } //Length: 72
	}

	[Token(Token = "0x17000003")]
	public int ReceiveQueueCount
	{
		[Address(RVA = "0x109E3F0", Offset = "0x109D5F0", Length = "0x48")]
		[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetTotalReceiveQueue>b__54_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(int))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 72
	}

	[Token(Token = "0x17000004")]
	public int SendBufferCount
	{
		[Address(RVA = "0x109E440", Offset = "0x109D640", Length = "0x48")]
		[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetTotalSendBuffer>b__55_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(int))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000020")]
		 get { } //Length: 72
	}

	[Token(Token = "0x17000002")]
	public int SendQueueCount
	{
		[Address(RVA = "0x109E490", Offset = "0x109D690", Length = "0x48")]
		[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetTotalSendQueue>b__53_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(int))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 72
	}

	[Address(RVA = "0x109E120", Offset = "0x109D320", Length = "0x1F7")]
	[CalledBy(Type = typeof(KcpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(Action), typeof(System.Action`2<kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpServer), Member = "CreateConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(KcpServerConnection))]
	[CalledBy(Type = typeof(KcpServerConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<kcp2k.KcpServerConnection>), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(Action), typeof(System.Action`2<kcp2k.ErrorCode, System.String>), typeof(System.Action`1<System.ArraySegment`1<System.Byte>>), typeof(KcpConfig), typeof(uint), typeof(EndPoint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(KcpPeer), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	protected KcpPeer(KcpConfig config, uint cookie) { }

	[Address(RVA = "0x109BC20", Offset = "0x109AE20", Length = "0xDF")]
	[CalledBy(Type = typeof(KcpClient), Member = "RawReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpPeer), Member = "SendDisconnect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000040")]
	public override void Disconnect() { }

	[Address(RVA = "0x109E320", Offset = "0x109D520", Length = "0x30")]
	[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetAverageMaxReceiveRate>b__52_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(long))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000026")]
	public uint get_MaxReceiveRate() { }

	[Address(RVA = "0x109E360", Offset = "0x109D560", Length = "0x30")]
	[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetAverageMaxSendRate>b__51_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(long))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000025")]
	public uint get_MaxSendRate() { }

	[Address(RVA = "0x109E3A0", Offset = "0x109D5A0", Length = "0x48")]
	[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetTotalReceiveBuffer>b__56_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000021")]
	public int get_ReceiveBufferCount() { }

	[Address(RVA = "0x109E3F0", Offset = "0x109D5F0", Length = "0x48")]
	[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetTotalReceiveQueue>b__54_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001F")]
	public int get_ReceiveQueueCount() { }

	[Address(RVA = "0x109E440", Offset = "0x109D640", Length = "0x48")]
	[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetTotalSendBuffer>b__55_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000020")]
	public int get_SendBufferCount() { }

	[Address(RVA = "0x109E490", Offset = "0x109D690", Length = "0x48")]
	[CalledBy(Type = "kcp2k.KcpTransport+<>c", Member = "<GetTotalSendQueue>b__53_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpServerConnection)}, ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001E")]
	public int get_SendQueueCount() { }

	[Address(RVA = "0x109BD00", Offset = "0x109AF00", Length = "0x485")]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Connected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Authenticated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000031")]
	private void HandleChoked() { }

	[Address(RVA = "0x109C190", Offset = "0x109B390", Length = "0xC8")]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Connected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Authenticated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600002F")]
	private void HandleDeadLink() { }

	[Address(RVA = "0x109C260", Offset = "0x109B460", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "SendReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000030")]
	private void HandlePing(uint time) { }

	[Address(RVA = "0x109C2B0", Offset = "0x109B4B0", Length = "0xB2")]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Connected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Authenticated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600002E")]
	private void HandleTimeout(uint time) { }

	[Token(Token = "0x6000029")]
	protected abstract void OnAuthenticated() { }

	[Token(Token = "0x600002A")]
	protected abstract void OnData(ArraySegment<Byte> message, KcpChannel channel) { }

	[Token(Token = "0x600002B")]
	protected abstract void OnDisconnected() { }

	[Token(Token = "0x600002C")]
	protected abstract void OnError(ErrorCode error, string message) { }

	[Address(RVA = "0x109C370", Offset = "0x109B570", Length = "0x17B")]
	[CalledBy(Type = typeof(KcpClient), Member = "RawInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpServerConnection), Member = "RawInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Kcp), Member = "Input", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000037")]
	protected void OnRawInputReliable(ArraySegment<Byte> message) { }

	[Address(RVA = "0x109C4F0", Offset = "0x109B6F0", Length = "0x333")]
	[CalledBy(Type = typeof(KcpClient), Member = "RawInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpServerConnection), Member = "RawInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000038")]
	protected void OnRawInputUnreliable(ArraySegment<Byte> message) { }

	[Token(Token = "0x600002D")]
	protected abstract void RawSend(ArraySegment<Byte> data) { }

	[Address(RVA = "0x109C830", Offset = "0x109BA30", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	private void RawSendReliable(Byte[] data, int length) { }

	[Address(RVA = "0x109C980", Offset = "0x109BB80", Length = "0x34B")]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Connected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Authenticated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Kcp), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Kcp), Member = "PeekSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000032")]
	private bool ReceiveNextReliable(out KcpHeaderReliable header, out ArraySegment<Byte>& message) { }

	[Address(RVA = "0x109CCE0", Offset = "0x109BEE0", Length = "0x63")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "GetMaxPacketSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "GetMaxPacketSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "GetMaxPacketSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000023")]
	public static int ReliableMaxMessageSize(int mtu, uint rcv_wnd) { }

	[Address(RVA = "0x109CCD0", Offset = "0x109BED0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000022")]
	private static int ReliableMaxMessageSize_Unconstrained(int mtu, uint rcv_wnd) { }

	[Address(RVA = "0x109CD50", Offset = "0x109BF50", Length = "0x289")]
	[CalledBy(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpConfig), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Kcp), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.Action`2<Byte[], System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stopwatch), Member = "Restart", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000028")]
	protected void Reset(KcpConfig config) { }

	[Address(RVA = "0x109CFE0", Offset = "0x109C1E0", Length = "0x126")]
	[CalledBy(Type = typeof(KcpClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpServer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(KcpPeer), Member = "SendReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "SendUnreliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderUnreliable), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600003D")]
	public void SendData(ArraySegment<Byte> data, KcpChannel channel) { }

	[Address(RVA = "0x109D110", Offset = "0x109C310", Length = "0x2FF")]
	[CalledBy(Type = typeof(KcpPeer), Member = "Disconnect", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003F")]
	private void SendDisconnect() { }

	[Address(RVA = "0x109D410", Offset = "0x109C610", Length = "0xE4")]
	[CalledBy(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpServerConnection), Member = "OnAuthenticated", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KcpPeer), Member = "SendReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	public void SendHello() { }

	[Address(RVA = "0x109D500", Offset = "0x109C700", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "SendReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600003E")]
	private void SendPing() { }

	[Address(RVA = "0x109D530", Offset = "0x109C730", Length = "0x258")]
	[CalledBy(Type = typeof(KcpPeer), Member = "HandlePing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Connected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming_Authenticated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = "SendHello", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = "SendData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpPeer), Member = "SendPing", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Kcp), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003A")]
	private void SendReliable(KcpHeaderReliable header, ArraySegment<Byte> content) { }

	[Address(RVA = "0x109D790", Offset = "0x109C990", Length = "0x2C2")]
	[CalledBy(Type = typeof(KcpPeer), Member = "SendData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600003B")]
	private void SendUnreliable(KcpHeaderUnreliable header, ArraySegment<Byte> content) { }

	[Address(RVA = "0x109DEC0", Offset = "0x109D0C0", Length = "0xFA")]
	[CalledBy(Type = typeof(KcpClient), Member = "TickIncoming", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpPeer), Member = "TickIncoming_Authenticated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "TickIncoming_Connected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000035")]
	public override void TickIncoming() { }

	[Address(RVA = "0x109DA60", Offset = "0x109CC60", Length = "0x258")]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KcpPeer), Member = "HandleChoked", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpPeer), Member = "HandleTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "HandleDeadLink", ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "SendReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(KcpPeer), Member = "ReceiveNextReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable&), typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000034")]
	private void TickIncoming_Authenticated(uint time) { }

	[Address(RVA = "0x109DCC0", Offset = "0x109CEC0", Length = "0x1F9")]
	[CalledBy(Type = typeof(KcpPeer), Member = "TickIncoming", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpPeer), Member = "HandleTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "HandleDeadLink", ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "SendReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "HandleChoked", ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "ReceiveNextReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpHeaderReliable&), typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000033")]
	private void TickIncoming_Connected(uint time) { }

	[Address(RVA = "0x109DFC0", Offset = "0x109D1C0", Length = "0x143")]
	[CalledBy(Type = typeof(KcpClient), Member = "TickOutgoing", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Kcp), Member = "Flush", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000036")]
	public override void TickOutgoing() { }

	[Address(RVA = "0x109E110", Offset = "0x109D310", Length = "0x4")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "GetMaxPacketSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "GetBatchThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "GetMaxPacketSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "GetBatchThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "GetMaxPacketSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "GetBatchThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Token(Token = "0x6000024")]
	public static int UnreliableMaxMessageSize(int mtu) { }

}

