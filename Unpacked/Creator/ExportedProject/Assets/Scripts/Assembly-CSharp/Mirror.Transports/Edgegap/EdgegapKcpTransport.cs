namespace Edgegap;

[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/edgegap-transports/edgegap-relay")]
[Token(Token = "0x2000045")]
public class EdgegapKcpTransport : KcpTransport
{
	[CompilerGenerated]
	[Token(Token = "0x2000046")]
	private sealed class <>c
	{
		[Token(Token = "0x4000185")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000186")]
		public static Action<String> <>9__8_0; //Field offset: 0x8

		[Address(RVA = "0x1286950", Offset = "0x1285B50", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001DD")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DE")]
		public <>c() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DF")]
		internal void <Awake>b__8_0(string _) { }

	}

	[Token(Token = "0x4000181")]
	public const int MaxPayload = 1187; //Field offset: 0x0
	[FieldOffset(Offset = "0xE0")]
	[Header("Relay")]
	[Token(Token = "0x400017E")]
	public string relayAddress; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400017F")]
	public ushort relayGameServerPort; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEA")]
	[Token(Token = "0x4000180")]
	public ushort relayGameClientPort; //Field offset: 0xEA
	[FieldOffset(Offset = "0xEC")]
	[Header("Relay")]
	[Token(Token = "0x4000182")]
	public bool relayGUI; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000183")]
	public uint userId; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000184")]
	public uint sessionId; //Field offset: 0xF4

	[Address(RVA = "0x1272800", Offset = "0x1271A00", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001D4")]
	public EdgegapKcpTransport() { }

	[Address(RVA = "0x12725F0", Offset = "0x12717F0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D5")]
	private void <Awake>b__8_1() { }

	[Address(RVA = "0x1272620", Offset = "0x1271820", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D6")]
	private void <Awake>b__8_2(ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x1272660", Offset = "0x1271860", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D7")]
	private void <Awake>b__8_3() { }

	[Address(RVA = "0x1272680", Offset = "0x1271880", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpTransport), Member = "ToTransportError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode)}, ReturnType = typeof(TransportError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x60001D8")]
	private void <Awake>b__8_4(ErrorCode error, string reason) { }

	[Address(RVA = "0x12726D0", Offset = "0x12718D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "PrettyAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D9")]
	private void <Awake>b__8_5(int connectionId, IPEndPoint endPoint) { }

	[Address(RVA = "0x1272720", Offset = "0x1271920", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DA")]
	private void <Awake>b__8_6(int connectionId, ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x1272770", Offset = "0x1271970", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DB")]
	private void <Awake>b__8_7(int connectionId) { }

	[Address(RVA = "0x12727A0", Offset = "0x12719A0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpTransport), Member = "ToTransportError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode)}, ReturnType = typeof(TransportError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DC")]
	private void <Awake>b__8_8(int connectionId, ErrorCode error, string reason) { }

	[Address(RVA = "0x1271720", Offset = "0x1270920", Length = "0x6DB")]
	[CalledBy(Type = typeof(EdgegapLobbyKcpTransport), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpServer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Net.IPEndPoint>), typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(System.Action`1<System.Int32>), typeof(System.Action`3<System.Int32, kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ByteEnum, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, System.ByteEnum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(KcpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(Action), typeof(System.Action`2<kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpConfig), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(uint), typeof(int), typeof(bool), typeof(uint), typeof(uint), typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeRepeating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x60001CC")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1271F70", Offset = "0x1271170", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CE")]
	public virtual void ClientConnect(string address) { }

	[Address(RVA = "0x1271E00", Offset = "0x1271000", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60001CF")]
	public virtual void ClientConnect(Uri uri) { }

	[Address(RVA = "0x12723E0", Offset = "0x12715E0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EdgegapKcpTransport), Member = "OnGUIRelay", ReturnType = typeof(void))]
	[Token(Token = "0x60001D2")]
	private void OnGUI() { }

	[Address(RVA = "0x1272020", Offset = "0x1271220", Length = "0x3BA")]
	[CalledBy(Type = typeof(EdgegapKcpTransport), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(GUILayout), Member = "EndArea", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUILayout), Member = "EndHorizontal", ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUILayout), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUILayout), Member = "TextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(string))]
	[Token(Token = "0x60001D1")]
	private void OnGUIRelay() { }

	[Address(RVA = "0x1272400", Offset = "0x1271600", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "ReliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "UnreliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x60001CD")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x1272440", Offset = "0x1271640", Length = "0xCF")]
	[CalledBy(Type = typeof(RelayCredentialsFromArgs), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CB")]
	internal static string ReParse(string cmd, string pattern, string defaultValue) { }

	[Address(RVA = "0x1272510", Offset = "0x1271710", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EdgegapKcpServer), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D0")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x12725C0", Offset = "0x12717C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60001D3")]
	public virtual string ToString() { }

}

