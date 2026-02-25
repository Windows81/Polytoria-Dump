namespace Edgegap;

[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/edgegap-transports/edgegap-relay")]
[Token(Token = "0x2000020")]
public class EdgegapLobbyKcpTransport : EdgegapKcpTransport
{
	[CompilerGenerated]
	[Token(Token = "0x2000022")]
	private sealed class <>c
	{
		[Token(Token = "0x4000103")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000104")]
		public static Action <>9__13_0; //Field offset: 0x8
		[Token(Token = "0x4000105")]
		public static Action <>9__14_0; //Field offset: 0x10

		[Address(RVA = "0x1286B10", Offset = "0x1285D10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000181")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000182")]
		public <>c() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000184")]
		internal void <ClientDisconnect>b__14_0() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000183")]
		internal void <ServerStop>b__13_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000023")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000106")]
		public EdgegapLobbyKcpTransport <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000107")]
		public bool running; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x4000108")]
		public bool forServer; //Field offset: 0x19

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000185")]
		public <>c__DisplayClass16_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000024")]
	private sealed class <>c__DisplayClass16_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000109")]
		public bool waitingForResponse; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010A")]
		public <>c__DisplayClass16_0 CS$<>8__locals1; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000186")]
		public <>c__DisplayClass16_1() { }

		[Address(RVA = "0x1285050", Offset = "0x1284250", Length = "0x5E4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EdgegapKcpServer), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000187")]
		internal void <WaitForLobbyRelay>b__0(Lobby lobby) { }

		[Address(RVA = "0x1285640", Offset = "0x1284840", Length = "0x174")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000188")]
		internal void <WaitForLobbyRelay>b__1(string error) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private sealed class <WaitForLobbyRelay>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400010D")]
		public EdgegapLobbyKcpTransport <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400010E")]
		public bool forServer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400010F")]
		private <>c__DisplayClass16_0 <>8__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000110")]
		public string lobbyId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000111")]
		private <>c__DisplayClass16_1 <>8__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000112")]
		private double <startTime>5__2; //Field offset: 0x48

		[Token(Token = "0x17000015")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600018C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000016")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600018E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000189")]
		public <WaitForLobbyRelay>d__16(int <>1__state) { }

		[Address(RVA = "0x1286B80", Offset = "0x1285D80", Length = "0x508")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Action`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WaitForSeconds), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600018B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600018C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600018E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1287090", Offset = "0x1286290", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x600018D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600018A")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000021")]
	internal enum TransportStatus
	{
		Offline = 0,
		CreatingLobby = 1,
		StartingLobby = 2,
		JoiningLobby = 3,
		WaitingRelay = 4,
		Connecting = 5,
		Connected = 6,
		Error = 7,
	}

	[FieldOffset(Offset = "0xF8")]
	[Header("Lobby Settings")]
	[Token(Token = "0x40000F3")]
	[Tooltip("URL to the Edgegap lobby service, automatically filled in after completing the creation process via button below (or enter manually)")]
	public string lobbyUrl; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000F4")]
	[Tooltip("How long to wait for the relay to be assigned after starting a lobby")]
	public float lobbyWaitTimeout; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000F5")]
	public LobbyApi Api; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40000F6")]
	private Nullable<LobbyCreateRequest> _request; //Field offset: 0x110
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40000F7")]
	private string _lobbyId; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40000F8")]
	private string _playerId; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40000F9")]
	private TransportStatus _status; //Field offset: 0x150

	[Token(Token = "0x17000014")]
	public TransportStatus Status
	{
		[Address(RVA = "0x12741C0", Offset = "0x12733C0", Length = "0x220")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600016A")]
		 get { } //Length: 544
	}

	[Address(RVA = "0x12740D0", Offset = "0x12732D0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000176")]
	public EdgegapLobbyKcpTransport() { }

	[Address(RVA = "0x1272510", Offset = "0x1271710", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EdgegapKcpServer), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DebuggerHidden]
	[DeduplicatedMethod]
	[Token(Token = "0x600017F")]
	private void <>n__0() { }

	[Address(RVA = "0x1271F70", Offset = "0x1271170", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[DebuggerHidden]
	[DeduplicatedMethod]
	[Token(Token = "0x6000180")]
	private void <>n__1(string address) { }

	[Address(RVA = "0x1273A60", Offset = "0x1272C60", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EdgegapLobbyKcpTransport), Member = "WaitForLobbyRelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600017D")]
	private void <ClientConnect>b__15_0() { }

	[Address(RVA = "0x1273A90", Offset = "0x1272C90", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[Token(Token = "0x600017E")]
	private void <ClientConnect>b__15_1(string error) { }

	[Address(RVA = "0x1273B50", Offset = "0x1272D50", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600017C")]
	private void <ClientDisconnect>b__14_1(string error) { }

	[Address(RVA = "0x1273BF0", Offset = "0x1272DF0", Length = "0x22F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CompilerGenerated]
	[Token(Token = "0x6000177")]
	private void <ServerStart>b__12_0(Lobby lobby) { }

	[Address(RVA = "0x1273E20", Offset = "0x1273020", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600017A")]
	private void <ServerStart>b__12_1(string error) { }

	[Address(RVA = "0x1273ED0", Offset = "0x12730D0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EdgegapLobbyKcpTransport), Member = "WaitForLobbyRelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6000178")]
	private void <ServerStart>b__12_2() { }

	[Address(RVA = "0x1273F00", Offset = "0x1273100", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[Token(Token = "0x6000179")]
	private void <ServerStart>b__12_3(string error) { }

	[Address(RVA = "0x1273FC0", Offset = "0x12731C0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600017B")]
	private void <ServerStop>b__13_1(string error) { }

	[Address(RVA = "0x12728E0", Offset = "0x1271AE0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EdgegapKcpTransport), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600016B")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1272970", Offset = "0x1271B70", Length = "0x2F1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000170")]
	public virtual void ClientConnect(string address) { }

	[Address(RVA = "0x1272C70", Offset = "0x1271E70", Length = "0x394")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600016F")]
	public virtual void ClientDisconnect() { }

	[Address(RVA = "0x12741C0", Offset = "0x12733C0", Length = "0x220")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016A")]
	public TransportStatus get_Status() { }

	[Address(RVA = "0x1273010", Offset = "0x1272210", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000175")]
	private void OnDestroy() { }

	[Address(RVA = "0x1273100", Offset = "0x1272300", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000172")]
	private static string RandomPlayerId() { }

	[Address(RVA = "0x1273160", Offset = "0x1272360", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600016C")]
	private void Reset() { }

	[Address(RVA = "0x1273170", Offset = "0x1272370", Length = "0x2F2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600016D")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x1273470", Offset = "0x1272670", Length = "0x2F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(LobbyApi), Member = "SendJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.AsyncOperation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600016E")]
	public virtual void ServerStop() { }

	[Address(RVA = "0x1273770", Offset = "0x1272970", Length = "0x1F4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Nullable`1<Edgegap.LobbyCreateRequest>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyCreateRequest)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000173")]
	public void SetServerLobbyParams(string lobbyName, int capacity) { }

	[Address(RVA = "0x1273970", Offset = "0x1272B70", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Nullable`1<Edgegap.LobbyCreateRequest>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyCreateRequest)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000174")]
	public void SetServerLobbyParams(LobbyCreateRequest request) { }

	[Address(RVA = "0x1274030", Offset = "0x1273230", Length = "0x96")]
	[CalledBy(Type = typeof(EdgegapLobbyKcpTransport), Member = "<ServerStart>b__12_2", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdgegapLobbyKcpTransport), Member = "<ClientConnect>b__15_0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<WaitForLobbyRelay>d__16))]
	[Token(Token = "0x6000171")]
	private IEnumerator WaitForLobbyRelay(string lobbyId, bool forServer) { }

}

