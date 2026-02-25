namespace Mirror;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/transports/latency-simulaton-transport")]
[Token(Token = "0x2000009")]
public class LatencySimulation : Transport, PortTransport
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000043")]
	public Transport wrap; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Header("Common")]
	[Range(0, 10000)]
	[Token(Token = "0x4000044")]
	[Tooltip("Latency in milliseconds (1000 = 1 second). Always applied to both reliable and unreliable, otherwise unreliable NetworkTime may be behind reliable [SyncVars/Commands/Rpcs] or vice versa!")]
	public float latency; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[FormerlySerializedAs("latencySpikeMultiplier")]
	[Range(0, 1)]
	[Token(Token = "0x4000045")]
	[Tooltip("Jitter latency via perlin(Time * jitterSpeed) * jitter")]
	public float jitter; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[FormerlySerializedAs("latencySpikeSpeedMultiplier")]
	[Token(Token = "0x4000046")]
	[Tooltip("Jitter latency via perlin(Time * jitterSpeed) * jitter")]
	public float jitterSpeed; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Header("Reliable Messages")]
	[Header("Unreliable Messages")]
	[Range(0, 100)]
	[Token(Token = "0x4000047")]
	[Tooltip("Packet loss in %\n2% recommended for long term play testing, upto 5% for short bursts.\nAnything higher, or for a prolonged amount of time, suggests user has a connection fault.")]
	public float unreliableLoss; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Range(0, 100)]
	[Token(Token = "0x4000048")]
	[Tooltip("Scramble % of unreliable messages, just like over the real network. Mirror unreliable is unordered.")]
	public float unreliableScramble; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000049")]
	private readonly List<QueuedMessage> clientToServer; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400004A")]
	private readonly List<QueuedMessage> serverToClient; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400004B")]
	private readonly Random random; //Field offset: 0xB8

	[Token(Token = "0x17000003")]
	public override ushort Port
	{
		[Address(RVA = "0x127C040", Offset = "0x127B240", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 171
		[Address(RVA = "0x127C0F0", Offset = "0x127B2F0", Length = "0xC0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[Token(Token = "0x600005E")]
		 set { } //Length: 192
	}

	[Address(RVA = "0x127BF20", Offset = "0x127B120", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600007A")]
	public LatencySimulation() { }

	[Address(RVA = "0x10A3E50", Offset = "0x10A3050", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000065")]
	public virtual bool Available() { }

	[Address(RVA = "0x127B1F0", Offset = "0x127A3F0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600005F")]
	public void Awake() { }

	[Address(RVA = "0x127B380", Offset = "0x127A580", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000067")]
	public virtual void ClientConnect(Uri uri) { }

	[Address(RVA = "0x127B2A0", Offset = "0x127A4A0", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000066")]
	public virtual void ClientConnect(string address) { }

	[Address(RVA = "0x10A3F60", Offset = "0x10A3160", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000068")]
	public virtual bool ClientConnected() { }

	[Address(RVA = "0x127B460", Offset = "0x127A660", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000069")]
	public virtual void ClientDisconnect() { }

	[Address(RVA = "0x10A3FC0", Offset = "0x10A31C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000072")]
	public virtual void ClientEarlyUpdate() { }

	[Address(RVA = "0x127B4F0", Offset = "0x127A6F0", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000074")]
	public virtual void ClientLateUpdate() { }

	[Address(RVA = "0x127B660", Offset = "0x127A860", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LatencySimulation), Member = "SimulateLatency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LatencySimulation), Member = "SimulateSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int), typeof(float), typeof(System.Collections.Generic.List`1<Mirror.QueuedMessage>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600006A")]
	public virtual void ClientSend(ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x127C040", Offset = "0x127B240", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x600005D")]
	public override ushort get_Port() { }

	[Address(RVA = "0x10A4060", Offset = "0x10A3260", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public virtual int GetBatchThreshold(int channelId) { }

	[Address(RVA = "0x10A4090", Offset = "0x10A3290", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000077")]
	public virtual int GetMaxPacketSize(int channelId = 0) { }

	[Address(RVA = "0x127B6D0", Offset = "0x127A8D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000062")]
	protected override float Noise(float time) { }

	[Address(RVA = "0x127B6E0", Offset = "0x127A8E0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000061")]
	private void OnDisable() { }

	[Address(RVA = "0x127B710", Offset = "0x127A910", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000060")]
	private void OnEnable() { }

	[Address(RVA = "0x10A40C0", Offset = "0x10A32C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006C")]
	public virtual bool ServerActive() { }

	[Address(RVA = "0x10A40F0", Offset = "0x10A32F0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006E")]
	public virtual void ServerDisconnect(int connectionId) { }

	[Address(RVA = "0x10A4120", Offset = "0x10A3320", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000073")]
	public virtual void ServerEarlyUpdate() { }

	[Address(RVA = "0x10A4150", Offset = "0x10A3350", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006D")]
	public virtual string ServerGetClientAddress(int connectionId) { }

	[Address(RVA = "0x127B740", Offset = "0x127A940", Length = "0x180")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000075")]
	public virtual void ServerLateUpdate() { }

	[Address(RVA = "0x127B8D0", Offset = "0x127AAD0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LatencySimulation), Member = "SimulateLatency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LatencySimulation), Member = "SimulateSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int), typeof(float), typeof(System.Collections.Generic.List`1<Mirror.QueuedMessage>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600006F")]
	public virtual void ServerSend(int connectionId, ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x127B950", Offset = "0x127AB50", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x127BA50", Offset = "0x127AC50", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000071")]
	public virtual void ServerStop() { }

	[Address(RVA = "0x10A4300", Offset = "0x10A3500", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006B")]
	public virtual Uri ServerUri() { }

	[Address(RVA = "0x127C0F0", Offset = "0x127B2F0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[Token(Token = "0x600005E")]
	public override void set_Port(ushort value) { }

	[Address(RVA = "0x10A4330", Offset = "0x10A3530", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000078")]
	public virtual void Shutdown() { }

	[Address(RVA = "0x127BAE0", Offset = "0x127ACE0", Length = "0x7C")]
	[CalledBy(Type = typeof(LatencySimulation), Member = "ClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LatencySimulation), Member = "ServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000063")]
	private float SimulateLatency(int channeldId) { }

	[Address(RVA = "0x127BB60", Offset = "0x127AD60", Length = "0x358")]
	[CalledBy(Type = typeof(LatencySimulation), Member = "ClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LatencySimulation), Member = "ServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000064")]
	private void SimulateSend(int connectionId, ArraySegment<Byte> segment, int channelId, float latency, List<QueuedMessage> messageQueue) { }

	[Address(RVA = "0x127BEC0", Offset = "0x127B0C0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000079")]
	public virtual string ToString() { }

}

