namespace Polytoria.Datamodel;

[DefaultMember("Item")]
[Token(Token = "0x200030D")]
public class BaseScript : Instance
{
	[CompilerGenerated]
	[Token(Token = "0x200030E")]
	private sealed class <<RpcRun>g__DelayedRun|18_0>d : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BB2")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BB3")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BB4")]
		public BaseScript <>4__this; //Field offset: 0x20

		[Token(Token = "0x170008E0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C26")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170008E1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C28")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C23")]
		public <<RpcRun>g__DelayedRun|18_0>d(int <>1__state) { }

		[Address(RVA = "0x418AD0", Offset = "0x417CD0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseScript), Member = "Run", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001C25")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C26")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C28")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x418B70", Offset = "0x417D70", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6001C27")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C24")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000BAB")]
	public bool running; //Field offset: 0xF8
	[FieldOffset(Offset = "0xF9")]
	[Token(Token = "0x4000BAC")]
	private bool requestedRun; //Field offset: 0xF9
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000BAD")]
	private ScriptService scriptService; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[MoonSharpHidden]
	[SyncVar]
	[Token(Token = "0x4000BAE")]
	public string source; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[MoonSharpHidden]
	[Token(Token = "0x4000BAF")]
	public Script script; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000BB0")]
	private DynValue updateFunc; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000BB1")]
	private DynValue fixedUpdateFunc; //Field offset: 0x120

	[Token(Token = "0x170008DE")]
	public object Item
	{
		[Address(RVA = "0x4018B0", Offset = "0x400AB0", Length = "0x2A")]
		[CalledBy(Type = typeof(BaseScriptProxy), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Table), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C09")]
		 get { } //Length: 42
		[Address(RVA = "0x4018E0", Offset = "0x400AE0", Length = "0x2A")]
		[CalledBy(Type = typeof(BaseScriptProxy), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Table), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C0A")]
		 set { } //Length: 42
	}

	[Token(Token = "0x170008DF")]
	public string Networksource
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C1C")]
		 get { } //Length: 8
		[Address(RVA = "0x401910", Offset = "0x400B10", Length = "0xB4")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C1D")]
		 set { } //Length: 180
	}

	[Archivable]
	[MoonSharpHidden]
	[Token(Token = "0x170008DD")]
	public string Source
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C07")]
		 get { } //Length: 8
		[Address(RVA = "0x401910", Offset = "0x400B10", Length = "0xB4")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C08")]
		 set { } //Length: 180
	}

	[Address(RVA = "0x401780", Offset = "0x400980", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C20")]
	private static BaseScript() { }

	[Address(RVA = "0x401860", Offset = "0x400A60", Length = "0x49")]
	[CalledBy(Type = typeof(LocalScript), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ModuleScript), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptInstance), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001C18")]
	public BaseScript() { }

	[Address(RVA = "0x4012F0", Offset = "0x4004F0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseScript), Member = "Run", ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x6001C19")]
	private void <Awake>b__11_0() { }

	[Address(RVA = "0x401380", Offset = "0x400580", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<RpcRun>g__DelayedRun|18_0>d))]
	[Token(Token = "0x6001C1A")]
	private IEnumerator <RpcRun>g__DelayedRun|18_0() { }

	[Address(RVA = "0x400590", Offset = "0x3FF790", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Instance), Member = "add__ParentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C0B")]
	protected virtual void Awake() { }

	[Address(RVA = "0x400610", Offset = "0x3FF810", Length = "0xDF")]
	[CalledBy(Type = typeof(BaseScriptProxy), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(ScriptService), Member = "CallFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C11")]
	public void Call(string function, Object[] args) { }

	[Address(RVA = "0x4006F0", Offset = "0x3FF8F0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C12")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x400790", Offset = "0x3FF990", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(System.Action`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C22")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x400830", Offset = "0x3FFA30", Length = "0x30D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScriptService), Member = "LuaPrint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(DynValue), Member = "IsNilOrNan", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6001C15")]
	public void FixedUpdate() { }

	[Address(RVA = "0x4018B0", Offset = "0x400AB0", Length = "0x2A")]
	[CalledBy(Type = typeof(BaseScriptProxy), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Table), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C09")]
	public object get_Item(string name) { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C1C")]
	public string get_Networksource() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C07")]
	public string get_Source() { }

	[Address(RVA = "0x400B40", Offset = "0x3FFD40", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001C1F")]
	protected static void InvokeUserCode_RpcRun(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x400CA0", Offset = "0x3FFEA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C16")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x400CB0", Offset = "0x3FFEB0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "OnNetworkStart", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C0D")]
	protected virtual void OnNetworkStart() { }

	[Address(RVA = "0x400DA0", Offset = "0x3FFFA0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnShow", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseScript), Member = "Run", ReturnType = typeof(void))]
	[Token(Token = "0x6001C17")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x400DD0", Offset = "0x3FFFD0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnStartClient", ReturnType = typeof(void))]
	[Token(Token = "0x6001C0E")]
	public virtual void OnStartClient() { }

	[Address(RVA = "0x400DE0", Offset = "0x3FFFE0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseScript), Member = "Run", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C13")]
	protected virtual void PostClone() { }

	[Address(RVA = "0x400E00", Offset = "0x400000", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x6001C10")]
	private void RpcRun() { }

	[Address(RVA = "0x400F50", Offset = "0x400150", Length = "0x2F6")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<>c", Member = "<RunLocalScripts>b__9_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseScript)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<<RpcRun>g__DelayedRun|18_0>d), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseScript), Member = "PostClone", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseScript), Member = "OnShow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseScript), Member = "<Awake>b__11_0", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<>c", Member = "<RunScripts>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseScript)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400290")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScriptService), Member = "RunScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseScript)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[MoonSharpHidden]
	[Token(Token = "0x6001C0F")]
	public void Run() { }

	[Address(RVA = "0x401250", Offset = "0x400450", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C21")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x4018E0", Offset = "0x400AE0", Length = "0x2A")]
	[CalledBy(Type = typeof(BaseScriptProxy), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Table), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C0A")]
	public void set_Item(string name, object value) { }

	[Address(RVA = "0x401910", Offset = "0x400B10", Length = "0xB4")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C1D")]
	public void set_Networksource(in string value) { }

	[Address(RVA = "0x401910", Offset = "0x400B10", Length = "0xB4")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C08")]
	public void set_Source(string value) { }

	[Address(RVA = "0x4012B0", Offset = "0x4004B0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001C0C")]
	protected virtual void Start() { }

	[Address(RVA = "0x4013F0", Offset = "0x4005F0", Length = "0x30D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScriptService), Member = "LuaPrint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
	[Calls(Type = typeof(DynValue), Member = "IsNilOrNan", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6001C14")]
	public void Update() { }

	[Address(RVA = "0x401700", Offset = "0x400900", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001C1E")]
	protected void UserCode_RpcRun() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C1B")]
	public virtual bool Weaved() { }

}

