namespace Mirror.Transports.Encryption;

[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/encryption-transport")]
[Token(Token = "0x2000019")]
public class EncryptionTransport : Transport, PortTransport
{
	[CompilerGenerated]
	[Token(Token = "0x200001B")]
	private sealed class <>c__DisplayClass27_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000DA")]
		public EncryptionTransport <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000DB")]
		public int connId; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000DC")]
		public EncryptedConnection ec; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000DD")]
		public string clientRemoteAddress; //Field offset: 0x28

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013F")]
		public <>c__DisplayClass27_0() { }

		[Address(RVA = "0x1286010", Offset = "0x1285210", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000140")]
		internal void <HandleInnerServerConnected>b__0(ArraySegment<Byte> segment, int channel) { }

		[Address(RVA = "0x1286070", Offset = "0x1285270", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000141")]
		internal void <HandleInnerServerConnected>b__1(ArraySegment<Byte> segment, int channel) { }

		[Address(RVA = "0x12860C0", Offset = "0x12852C0", Length = "0xCD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EncryptionTransport), Member = "ServerRemoveFromPending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptedConnection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000142")]
		internal void <HandleInnerServerConnected>b__2() { }

		[Address(RVA = "0x1286190", Offset = "0x1285390", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000143")]
		internal void <HandleInnerServerConnected>b__3(TransportError type, string msg) { }

	}

	[Token(Token = "0x200001A")]
	internal enum ValidationMode
	{
		Off = 0,
		List = 1,
		Callback = 2,
	}

	[FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("inner")]
	[HideInInspector]
	[Token(Token = "0x40000CC")]
	public Transport Inner; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[FormerlySerializedAs("clientValidateServerPubKey")]
	[HideInInspector]
	[Token(Token = "0x40000CD")]
	public ValidationMode ClientValidateServerPubKey; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[FormerlySerializedAs("clientTrustedPubKeySignatures")]
	[HideInInspector]
	[Token(Token = "0x40000CE")]
	[Tooltip("List of public key fingerprints the client will accept")]
	public String[] ClientTrustedPubKeySignatures; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000CF")]
	public Func<PubKeyInfo, Boolean> OnClientValidateServerPubKey; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[FormerlySerializedAs("serverLoadKeyPairFromFile")]
	[HideInInspector]
	[Token(Token = "0x40000D0")]
	public bool ServerLoadKeyPairFromFile; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[FormerlySerializedAs("serverKeypairPath")]
	[HideInInspector]
	[Token(Token = "0x40000D1")]
	public string ServerKeypairPath; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000D2")]
	private EncryptedConnection client; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000D3")]
	private readonly Dictionary<Int32, EncryptedConnection> serverConnections; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000D4")]
	private readonly List<EncryptedConnection> serverPendingConnections; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000D5")]
	private EncryptionCredentials credentials; //Field offset: 0xD0

	[Token(Token = "0x1700000C")]
	public virtual string EncryptionCipher
	{
		[Address(RVA = "0x1278A00", Offset = "0x1277C00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000114")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700000F")]
	public Byte[] EncryptionPublicKey
	{
		[Address(RVA = "0x1278A50", Offset = "0x1277C50", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000118")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700000E")]
	public string EncryptionPublicKeyFingerprint
	{
		[Address(RVA = "0x1278A30", Offset = "0x1277C30", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000117")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700000B")]
	public virtual bool IsEncrypted
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000113")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700000D")]
	public override ushort Port
	{
		[Address(RVA = "0x1278A70", Offset = "0x1277C70", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6000115")]
		 get { } //Length: 171
		[Address(RVA = "0x1278B20", Offset = "0x1277D20", Length = "0xC0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[Token(Token = "0x6000116")]
		 set { } //Length: 192
	}

	[Address(RVA = "0x1278900", Offset = "0x1277B00", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000138")]
	public EncryptionTransport() { }

	[Address(RVA = "0x1278800", Offset = "0x1277A00", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600013D")]
	private void <ClientConnect>b__36_0(ArraySegment<Byte> bytes, int channel) { }

	[Address(RVA = "0x10A4020", Offset = "0x10A3220", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000139")]
	private void <HandleInnerClientConnected>b__31_0(ArraySegment<Byte> segment, int channel) { }

	[Address(RVA = "0x1278830", Offset = "0x1277A30", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600013A")]
	private void <HandleInnerClientConnected>b__31_1(ArraySegment<Byte> segment, int channel) { }

	[Address(RVA = "0x1278860", Offset = "0x1277A60", Length = "0x19")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600013B")]
	private void <HandleInnerClientConnected>b__31_2() { }

	[Address(RVA = "0x1278880", Offset = "0x1277A80", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[Token(Token = "0x600013C")]
	private void <HandleInnerClientConnected>b__31_3(TransportError type, string msg) { }

	[Address(RVA = "0x12788C0", Offset = "0x1277AC0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600013E")]
	private void <ServerStart>b__41_0(int connId, ArraySegment<Byte> bytes, int channel) { }

	[Address(RVA = "0x10A3E50", Offset = "0x10A3050", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000125")]
	public virtual bool Available() { }

	[Address(RVA = "0x1277320", Offset = "0x1276520", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000124")]
	private void Awake() { }

	[Address(RVA = "0x12773B0", Offset = "0x12765B0", Length = "0x320")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EncryptionCredentials), Member = "Generate", ReturnType = typeof(EncryptionCredentials))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000127")]
	public virtual void ClientConnect(string address) { }

	[Address(RVA = "0x12776E0", Offset = "0x12768E0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000126")]
	public virtual bool ClientConnected() { }

	[Address(RVA = "0x10A3F90", Offset = "0x10A3190", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000129")]
	public virtual void ClientDisconnect() { }

	[Address(RVA = "0x10A3FC0", Offset = "0x10A31C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000134")]
	public virtual void ClientEarlyUpdate() { }

	[Address(RVA = "0x1277700", Offset = "0x1276900", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(EncryptedConnection), Member = "TickNonReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000135")]
	public virtual void ClientLateUpdate() { }

	[Address(RVA = "0x1277790", Offset = "0x1276990", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncryptedConnection), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000128")]
	public virtual void ClientSend(ArraySegment<Byte> segment, int channelId = 0) { }

	[Address(RVA = "0x1278A00", Offset = "0x1277C00", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000114")]
	public virtual string get_EncryptionCipher() { }

	[Address(RVA = "0x1278A50", Offset = "0x1277C50", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000118")]
	public Byte[] get_EncryptionPublicKey() { }

	[Address(RVA = "0x1278A30", Offset = "0x1277C30", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000117")]
	public string get_EncryptionPublicKeyFingerprint() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000113")]
	public virtual bool get_IsEncrypted() { }

	[Address(RVA = "0x1278A70", Offset = "0x1277C70", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x6000115")]
	public override ushort get_Port() { }

	[Address(RVA = "0x12777C0", Offset = "0x12769C0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000132")]
	public virtual int GetBatchThreshold(int channelId = 0) { }

	[Address(RVA = "0x1277800", Offset = "0x1276A00", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000131")]
	public virtual int GetMaxPacketSize(int channelId = 0) { }

	[Address(RVA = "0x1277840", Offset = "0x1276A40", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000123")]
	private bool HandleClientValidateServerPubKey(PubKeyInfo pubKeyInfo) { }

	[Address(RVA = "0x1277940", Offset = "0x1276B40", Length = "0x1D2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncryptedConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionCredentials), typeof(bool), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(Action), typeof(System.Action`2<Mirror.TransportError, System.String>), typeof(System.Func`2<Mirror.Transports.Encryption.PubKeyInfo, System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000122")]
	private void HandleInnerClientConnected() { }

	[Address(RVA = "0x1277B20", Offset = "0x1276D20", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000121")]
	private void HandleInnerClientDataReceived(ArraySegment<Byte> data, int channel) { }

	[Address(RVA = "0x1277B50", Offset = "0x1276D50", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011F")]
	private void HandleInnerClientDisconnected() { }

	[Address(RVA = "0x1277BA0", Offset = "0x1276DA0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000120")]
	private void HandleInnerClientError(TransportError arg1, string arg2) { }

	[Address(RVA = "0x1277C70", Offset = "0x1276E70", Length = "0x331")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncryptedConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionCredentials), typeof(bool), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(Action), typeof(System.Action`2<Mirror.TransportError, System.String>), typeof(System.Func`2<Mirror.Transports.Encryption.PubKeyInfo, System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600011E")]
	private void HandleInnerServerConnected(int connId, string clientRemoteAddress) { }

	[Address(RVA = "0x1277C20", Offset = "0x1276E20", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600011D")]
	private void HandleInnerServerConnected(int connId) { }

	[Address(RVA = "0x1277FB0", Offset = "0x12771B0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011C")]
	private void HandleInnerServerDataReceived(int connId, ArraySegment<Byte> data, int channel) { }

	[Address(RVA = "0x1278060", Offset = "0x1277260", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncryptionTransport), Member = "ServerRemoveFromPending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptedConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011A")]
	private void HandleInnerServerDisconnected(int connId) { }

	[Address(RVA = "0x1278120", Offset = "0x1277320", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600011B")]
	private void HandleInnerServerError(int connId, TransportError type, string msg) { }

	[Address(RVA = "0x10A40C0", Offset = "0x10A32C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012B")]
	public virtual bool ServerActive() { }

	[Address(RVA = "0x10A40F0", Offset = "0x10A32F0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012E")]
	public virtual void ServerDisconnect(int connectionId) { }

	[Address(RVA = "0x10A4120", Offset = "0x10A3320", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000136")]
	public virtual void ServerEarlyUpdate() { }

	[Address(RVA = "0x10A4150", Offset = "0x10A3350", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012F")]
	public virtual string ServerGetClientAddress(int connectionId) { }

	[Address(RVA = "0x12781B0", Offset = "0x12773B0", Length = "0x1D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(EncryptedConnection), Member = "TickNonReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000137")]
	public virtual void ServerLateUpdate() { }

	[Address(RVA = "0x1278390", Offset = "0x1277590", Length = "0x10A")]
	[CalledBy(Type = typeof(<>c__DisplayClass27_0), Member = "<HandleInnerServerConnected>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncryptionTransport), Member = "HandleInnerServerDisconnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000119")]
	private void ServerRemoveFromPending(EncryptedConnection con) { }

	[Address(RVA = "0x12784A0", Offset = "0x12776A0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncryptedConnection), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600012D")]
	public virtual void ServerSend(int connectionId, ArraySegment<Byte> segment, int channelId = 0) { }

	[Address(RVA = "0x1278550", Offset = "0x1277750", Length = "0x2A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EncryptionCredentials), Member = "Generate", ReturnType = typeof(EncryptionCredentials))]
	[Calls(Type = typeof(EncryptionCredentials), Member = "LoadFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(EncryptionCredentials))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ByteEnum, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012C")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x507450", Offset = "0x506650", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000130")]
	public virtual void ServerStop() { }

	[Address(RVA = "0x10A4300", Offset = "0x10A3500", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012A")]
	public virtual Uri ServerUri() { }

	[Address(RVA = "0x1278B20", Offset = "0x1277D20", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[Token(Token = "0x6000116")]
	public override void set_Port(ushort value) { }

	[Address(RVA = "0x10A4330", Offset = "0x10A3530", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000133")]
	public virtual void Shutdown() { }

}

