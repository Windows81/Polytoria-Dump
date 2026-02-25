namespace Mirror;

[Token(Token = "0x2000046")]
public abstract class NetworkConnection
{
	[Token(Token = "0x40000CE")]
	public const int LocalConnectionId = 0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CF")]
	public bool isAuthenticated; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D0")]
	public object authenticationData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D1")]
	public bool isReady; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000D2")]
	public float lastMessageTime; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D3")]
	private NetworkIdentity <identity>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D4")]
	public readonly HashSet<NetworkIdentity> owned; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000D5")]
	protected Dictionary<Int32, Batcher> batches; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000D6")]
	private double <remoteTimeStamp>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x17000036")]
	public internal NetworkIdentity identity
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BA")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BB")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000037")]
	public internal double remoteTimeStamp
	{
		[Address(RVA = "0x83D0F0", Offset = "0x83C2F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BC")]
		 get { } //Length: 6
		[Address(RVA = "0x83D120", Offset = "0x83C320", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BD")]
		internal set { } //Length: 6
	}

	[Address(RVA = "0x1265A10", Offset = "0x1264C10", Length = "0xCA")]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToServer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToServer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001BE")]
	internal NetworkConnection() { }

	[Address(RVA = "0x12653B0", Offset = "0x12645B0", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Batcher), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60001C6")]
	public override void Cleanup() { }

	[Token(Token = "0x60001C5")]
	public abstract void Disconnect() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BA")]
	public NetworkIdentity get_identity() { }

	[Address(RVA = "0x83D0F0", Offset = "0x83C2F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BC")]
	public double get_remoteTimeStamp() { }

	[Address(RVA = "0x12654D0", Offset = "0x12646D0", Length = "0x170")]
	[CalledBy(Type = typeof(LocalConnectionToClient), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToServer), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnection), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BF")]
	protected Batcher GetBatchForChannelId(int channelId) { }

	[Address(RVA = "0x1265650", Offset = "0x1264850", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001C4")]
	internal override bool IsAlive(float timeout) { }

	[Address(RVA = "0x70E830", Offset = "0x70DA30", Length = "0x40A")]
	[CalledBy(Type = "Mirror.Authenticators.BasicAuthenticator", Member = "OnAuthRequestMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Authenticators.BasicAuthenticator+AuthRequestMessage"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnAuthRequestMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Authenticators.DeviceAuthenticator+AuthRequestMessage"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTime), Member = "OnServerPing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(NetworkPingMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "BroadcastToConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "SendChangeOwnerMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "SetAllClientsNotReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "SetClientNotReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "SpawnObserversForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnServerAuthenticated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnServerConnectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "Broadcast", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "AddPlayer", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkClient), Member = "Ready", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkClient), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "SendTargetRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnection), typeof(string), typeof(int), typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator+<ValidateToken>d__5", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = "UpdatePing", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MessageInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkMessage), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(NetworkMessages), Member = "MaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkWriter), Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C0")]
	public void Send(T message, int channelId = 0) { }

	[Address(RVA = "0x1265680", Offset = "0x1264880", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkConnection), Member = "GetBatchForChannelId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Batcher))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(Batcher), Member = "AddMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C1")]
	internal override void Send(ArraySegment<Byte> segment, int channelId = 0) { }

	[Token(Token = "0x60001C2")]
	protected abstract void SendToTransport(ArraySegment<Byte> segment, int channelId = 0) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BB")]
	internal void set_identity(NetworkIdentity value) { }

	[Address(RVA = "0x83D120", Offset = "0x83C320", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BD")]
	internal void set_remoteTimeStamp(double value) { }

	[Address(RVA = "0x1265720", Offset = "0x1264920", Length = "0x2E1")]
	[CalledBy(Type = typeof(LocalConnectionToClient), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToServer), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(Batcher), Member = "GetBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C3")]
	internal override void Update() { }

}

