namespace Mirror;

[DisallowMultipleComponent]
[Token(Token = "0x2000004")]
public class MultiplexTransport : Transport, PortTransport
{
	[CompilerGenerated]
	[Token(Token = "0x2000005")]
	private sealed class <>c__DisplayClass26_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000C")]
		public int transportIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000D")]
		public MultiplexTransport <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000022")]
		public <>c__DisplayClass26_0() { }

		[Address(RVA = "0x153EA80", Offset = "0x153DC80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MultiplexTransport), Member = "AddToLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000023")]
		internal void <AddServerCallbacks>b__0(int originalConnectionId) { }

		[Address(RVA = "0x153EAD0", Offset = "0x153DCD0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MultiplexTransport), Member = "AddToLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000024")]
		internal void <AddServerCallbacks>b__1(int originalConnectionId, string address) { }

		[Address(RVA = "0x153EB30", Offset = "0x153DD30", Length = "0x1C0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MultiplexTransport), Member = "MultiplexId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Utils), Member = "IsHeadless", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "ResetColor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000025")]
		internal void <AddServerCallbacks>b__2(int originalConnectionId, ArraySegment<Byte> data, int channel) { }

		[Address(RVA = "0x153ED00", Offset = "0x153DF00", Length = "0x1B6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MultiplexTransport), Member = "MultiplexId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Utils), Member = "IsHeadless", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "ResetColor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000026")]
		internal void <AddServerCallbacks>b__3(int originalConnectionId, TransportError error, string reason) { }

		[Address(RVA = "0x153EEC0", Offset = "0x153E0C0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MultiplexTransport), Member = "MultiplexId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000027")]
		internal void <AddServerCallbacks>b__4(int originalConnectionId, Exception exception) { }

		[Address(RVA = "0x153EF20", Offset = "0x153E120", Length = "0x298")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MultiplexTransport), Member = "MultiplexId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Utils), Member = "IsHeadless", ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "ResetColor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000028")]
		internal void <AddServerCallbacks>b__5(int originalConnectionId) { }

	}

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000006")]
	public Transport[] transports; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000007")]
	private Transport available; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000008")]
	private readonly Dictionary<KeyValuePair`2<Int32, Int32>, Int32> originalToMultiplexedId; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000009")]
	private readonly Dictionary<Int32, KeyValuePair`2<Int32, Int32>> multiplexedToOriginalId; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400000A")]
	private int nextMultiplexedId; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400000B")]
	private bool alreadyWarned; //Field offset: 0xAC

	[Token(Token = "0x17000001")]
	public override ushort Port
	{
		[Address(RVA = "0x153E840", Offset = "0x153DA40", Length = "0xDD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000003")]
		 get { } //Length: 221
		[Address(RVA = "0x153E920", Offset = "0x153DB20", Length = "0x158")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Utils), Member = "IsHeadless", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Console), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Console), Member = "ResetColor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000004")]
		 set { } //Length: 344
	}

	[Address(RVA = "0x153E760", Offset = "0x153D960", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.KeyValuePair`2<System.Int32, System.Int32>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public MultiplexTransport() { }

	[Address(RVA = "0x153D1B0", Offset = "0x153C3B0", Length = "0x2C1")]
	[CalledBy(Type = typeof(MultiplexTransport), Member = "ServerStart", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ByteEnum, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000016")]
	private void AddServerCallbacks() { }

	[Address(RVA = "0x153D480", Offset = "0x153C680", Length = "0xCF")]
	[CalledBy(Type = typeof(<>c__DisplayClass26_0), Member = "<AddServerCallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass26_0), Member = "<AddServerCallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.KeyValuePair`2<System.Int32, System.Int32>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.KeyValuePair`2<System.Int32, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public int AddToLookup(int originalConnectionId, int transportIndex) { }

	[Address(RVA = "0x153D550", Offset = "0x153C750", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	public virtual bool Available() { }

	[Address(RVA = "0x153D5E0", Offset = "0x153C7E0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000009")]
	public void Awake() { }

	[Address(RVA = "0x153D7F0", Offset = "0x153C9F0", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000011")]
	public virtual void ClientConnect(string address) { }

	[Address(RVA = "0x153D660", Offset = "0x153C860", Length = "0x18C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000012")]
	public virtual void ClientConnect(Uri uri) { }

	[Address(RVA = "0x153D960", Offset = "0x153CB60", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public virtual bool ClientConnected() { }

	[Address(RVA = "0x153D990", Offset = "0x153CB90", Length = "0x26")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000014")]
	public virtual void ClientDisconnect() { }

	[Address(RVA = "0x153D9C0", Offset = "0x153CBC0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	public virtual void ClientEarlyUpdate() { }

	[Address(RVA = "0x153DA30", Offset = "0x153CC30", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public virtual void ClientLateUpdate() { }

	[Address(RVA = "0x153DAA0", Offset = "0x153CCA0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000015")]
	public virtual void ClientSend(ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x153E840", Offset = "0x153DA40", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	public override ushort get_Port() { }

	[Address(RVA = "0x153DAE0", Offset = "0x153CCE0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001E")]
	public virtual int GetMaxPacketSize(int channelId = 0) { }

	[Address(RVA = "0x153DB80", Offset = "0x153CD80", Length = "0x9C")]
	[CalledBy(Type = typeof(<>c__DisplayClass26_0), Member = "<AddServerCallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass26_0), Member = "<AddServerCallbacks>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass26_0), Member = "<AddServerCallbacks>b__4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass26_0), Member = "<AddServerCallbacks>b__5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	public int MultiplexId(int originalConnectionId, int transportIndex) { }

	[Address(RVA = "0x153DC20", Offset = "0x153CE20", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000F")]
	private void OnDisable() { }

	[Address(RVA = "0x153DC90", Offset = "0x153CE90", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000E")]
	private void OnEnable() { }

	[Address(RVA = "0x153DD00", Offset = "0x153CF00", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000007")]
	public bool OriginalId(int multiplexId, out int originalConnectionId, out int transportIndex) { }

	[Address(RVA = "0x153DDD0", Offset = "0x153CFD0", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public void RemoveFromLookup(int originalConnectionId, int transportIndex) { }

	[Address(RVA = "0x153DEC0", Offset = "0x153D0C0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000018")]
	public virtual bool ServerActive() { }

	[Address(RVA = "0x153DF50", Offset = "0x153D150", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001A")]
	public virtual void ServerDisconnect(int connectionId) { }

	[Address(RVA = "0x153E030", Offset = "0x153D230", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	public virtual void ServerEarlyUpdate() { }

	[Address(RVA = "0x153E0A0", Offset = "0x153D2A0", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	public virtual string ServerGetClientAddress(int connectionId) { }

	[Address(RVA = "0x153E1B0", Offset = "0x153D3B0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	public virtual void ServerLateUpdate() { }

	[Address(RVA = "0x153E220", Offset = "0x153D420", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	public virtual void ServerSend(int connectionId, ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x153E330", Offset = "0x153D530", Length = "0x1E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiplexTransport), Member = "AddServerCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Utils), Member = "IsHeadless", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "ResetColor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001C")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x153E520", Offset = "0x153D720", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	public virtual void ServerStop() { }

	[Address(RVA = "0x153E590", Offset = "0x153D790", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000017")]
	public virtual Uri ServerUri() { }

	[Address(RVA = "0x153E920", Offset = "0x153DB20", Length = "0x158")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "IsHeadless", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Console), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "ResetColor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	public override void set_Port(ushort value) { }

	[Address(RVA = "0x153E5E0", Offset = "0x153D7E0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001F")]
	public virtual void Shutdown() { }

	[Address(RVA = "0x153E650", Offset = "0x153D850", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	public virtual string ToString() { }

}

