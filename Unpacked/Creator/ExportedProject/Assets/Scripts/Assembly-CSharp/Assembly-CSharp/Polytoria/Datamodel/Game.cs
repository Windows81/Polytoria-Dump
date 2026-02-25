namespace Polytoria.Datamodel;

[Token(Token = "0x200031E")]
public class Game : Instance
{
	[CompilerGenerated]
	[Token(Token = "0x200031F")]
	private sealed class <WaitForGameLoad>d__29 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C60")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C61")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C62")]
		public Game <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C63")]
		private float <startTime>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000C64")]
		private float <timeout>5__3; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C65")]
		private int <lastInstances>5__4; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C66")]
		private float <timeSinceChange>5__5; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C67")]
		private float <minimumTime>5__6; //Field offset: 0x38

		[Token(Token = "0x17000946")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DA2")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000947")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6001DA4")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D9F")]
		public <WaitForGameLoad>d__29(int <>1__state) { }

		[Address(RVA = "0x43CEB0", Offset = "0x43C0B0", Length = "0x37D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Game), Member = "InvokeLoadedLocal", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DA1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DA2")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DA4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x43D230", Offset = "0x43C430", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6001DA3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DA0")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000C56")]
	public static Game singleton; //Field offset: 0x0
	[Token(Token = "0x4000C5B")]
	public static string GameName; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x4000C5E")]
	private static Action GameLoadedLocally; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000C57")]
	private Action Loaded; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000C58")]
	public LuaEvent Rendered; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SyncVar]
	[Token(Token = "0x4000C59")]
	private int gameID; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[SyncVar]
	[Token(Token = "0x4000C5A")]
	private int playersConnected; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[SyncVar]
	[Token(Token = "0x4000C5C")]
	public int instanceCount; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000C5D")]
	private int localInstanceCount; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000C5F")]
	public bool isGameLoaded; //Field offset: 0x118

	[Token(Token = "0x1400004C")]
	public static event Action GameLoadedLocally
	{
		[Address(RVA = "0x423340", Offset = "0x422540", Length = "0xB8")]
		[CalledBy(Type = typeof(DynamicInstance), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LoadScreenController), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001D88")]
		 add { } //Length: 184
		[Address(RVA = "0x4234E0", Offset = "0x4226E0", Length = "0xB8")]
		[CalledBy(Type = typeof(DynamicInstance), Member = "OnDestroy", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001D89")]
		 remove { } //Length: 184
	}

	[Token(Token = "0x1400004B")]
	public event Action Loaded
	{
		[Address(RVA = "0x423400", Offset = "0x422600", Length = "0xA2")]
		[CalledBy(Type = typeof(CreatorController), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001D82")]
		 add { } //Length: 162
		[Address(RVA = "0x4235A0", Offset = "0x4227A0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001D83")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x1700093F")]
	public int GameID
	{
		[Address(RVA = "0x4234B0", Offset = "0x4226B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D84")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000941")]
	public int InstanceCount
	{
		[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D86")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000942")]
	public int LocalInstanceCount
	{
		[Address(RVA = "0x4234C0", Offset = "0x4226C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D87")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000943")]
	public int NetworkgameID
	{
		[Address(RVA = "0x4234B0", Offset = "0x4226B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D97")]
		 get { } //Length: 7
		[Address(RVA = "0x422E80", Offset = "0x422080", Length = "0xB1")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D98")]
		 set { } //Length: 177
	}

	[Token(Token = "0x17000945")]
	public int NetworkinstanceCount
	{
		[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D9B")]
		 get { } //Length: 7
		[Address(RVA = "0x423650", Offset = "0x422850", Length = "0xB1")]
		[CalledBy(Type = typeof(Game), Member = "InstanceAdded", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Game), Member = "InstanceRemoved", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Instance), Member = "OnNetworkStart", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Instance), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NPC), Member = "OnNetworkStart", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001D9C")]
		 set { } //Length: 177
	}

	[Token(Token = "0x17000944")]
	public int NetworkplayersConnected
	{
		[Address(RVA = "0x4234D0", Offset = "0x4226D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D99")]
		 get { } //Length: 7
		[Address(RVA = "0x423710", Offset = "0x422910", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001D9A")]
		 set { } //Length: 177
	}

	[Token(Token = "0x17000940")]
	public int PlayersConnected
	{
		[Address(RVA = "0x4234D0", Offset = "0x4226D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D85")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x4232B0", Offset = "0x4224B0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LuaEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001D95")]
	public Game() { }

	[Address(RVA = "0x423340", Offset = "0x422540", Length = "0xB8")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LoadScreenController), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001D88")]
	public static void add_GameLoadedLocally(Action value) { }

	[Address(RVA = "0x423400", Offset = "0x422600", Length = "0xA2")]
	[CalledBy(Type = typeof(CreatorController), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001D82")]
	public void add_Loaded(Action value) { }

	[Address(RVA = "0x4225A0", Offset = "0x4217A0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[Token(Token = "0x6001D8A")]
	protected virtual void Awake() { }

	[Address(RVA = "0x422610", Offset = "0x421810", Length = "0x91")]
	[CalledBy(Type = typeof(GameIO), Member = "PostMapLoad", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "RebuildNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D8F")]
	public void BuildNavMesh() { }

	[Address(RVA = "0x4226B0", Offset = "0x4218B0", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(System.Action`2<System.Int32, System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D9E")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x4234B0", Offset = "0x4226B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D84")]
	public int get_GameID() { }

	[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D86")]
	public int get_InstanceCount() { }

	[Address(RVA = "0x4234C0", Offset = "0x4226C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D87")]
	public int get_LocalInstanceCount() { }

	[Address(RVA = "0x4234B0", Offset = "0x4226B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D97")]
	public int get_NetworkgameID() { }

	[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D9B")]
	public int get_NetworkinstanceCount() { }

	[Address(RVA = "0x4234D0", Offset = "0x4226D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D99")]
	public int get_NetworkplayersConnected() { }

	[Address(RVA = "0x4234D0", Offset = "0x4226D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D85")]
	public int get_PlayersConnected() { }

	[Address(RVA = "0x422800", Offset = "0x421A00", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Game), Member = "set_NetworkinstanceCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MoonSharpHidden]
	[Token(Token = "0x6001D93")]
	public void InstanceAdded() { }

	[Address(RVA = "0x4228E0", Offset = "0x421AE0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Game), Member = "set_NetworkinstanceCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MoonSharpHidden]
	[Token(Token = "0x6001D94")]
	public void InstanceRemoved() { }

	[Address(RVA = "0x422A20", Offset = "0x421C20", Length = "0x125")]
	[CalledBy(Type = typeof(GameIO), Member = "PostMapLoad", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001D8C")]
	public void InvokeLoaded() { }

	[Address(RVA = "0x4229C0", Offset = "0x421BC0", Length = "0x5D")]
	[CalledBy(Type = typeof(<WaitForGameLoad>d__29), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D8D")]
	public void InvokeLoadedLocal() { }

	[Address(RVA = "0x422B50", Offset = "0x421D50", Length = "0x24F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameIO), Member = "LoadFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameIO), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D8B")]
	public virtual void OnStartServer() { }

	[Address(RVA = "0x4234E0", Offset = "0x4226E0", Length = "0xB8")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001D89")]
	public static void remove_GameLoadedLocally(Action value) { }

	[Address(RVA = "0x4235A0", Offset = "0x4227A0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001D83")]
	public void remove_Loaded(Action value) { }

	[Address(RVA = "0x422DA0", Offset = "0x421FA0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D9D")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x422E80", Offset = "0x422080", Length = "0xB1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D98")]
	public void set_NetworkgameID(in int value) { }

	[Address(RVA = "0x423650", Offset = "0x422850", Length = "0xB1")]
	[CalledBy(Type = typeof(Game), Member = "InstanceAdded", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Game), Member = "InstanceRemoved", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Instance), Member = "OnNetworkStart", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Instance), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = "OnNetworkStart", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001D9C")]
	public void set_NetworkinstanceCount(in int value) { }

	[Address(RVA = "0x423710", Offset = "0x422910", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001D9A")]
	public void set_NetworkplayersConnected(in int value) { }

	[Address(RVA = "0x422E80", Offset = "0x422080", Length = "0xB1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D8E")]
	public void SetGameID(int id) { }

	[Address(RVA = "0x422F40", Offset = "0x422140", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001D90")]
	protected virtual void Start() { }

	[Address(RVA = "0x423050", Offset = "0x422250", Length = "0x1EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Token(Token = "0x6001D92")]
	private void Update() { }

	[Address(RVA = "0x423240", Offset = "0x422440", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<WaitForGameLoad>d__29))]
	[MoonSharpHidden]
	[Token(Token = "0x6001D91")]
	public IEnumerator WaitForGameLoad() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D96")]
	public virtual bool Weaved() { }

}

