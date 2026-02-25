namespace Mirror;

[Token(Token = "0x200004F")]
public static class NetworkLoop
{
	[CompilerGenerated]
	[Token(Token = "0x2000051")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000110")]
		public UpdateFunction function; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000230")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x126F6F0", Offset = "0x126E8F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000231")]
		internal bool <FindPlayerLoopEntryIndex>b__0(PlayerLoopSystem elem) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000052")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000111")]
		public UpdateFunction function; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000232")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x126F6F0", Offset = "0x126E8F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000233")]
		internal bool <AddToPlayerLoop>b__0(PlayerLoopSystem s) { }

	}

	[Token(Token = "0x2000050")]
	public enum AddMode
	{
		Beginning = 0,
		End = 1,
	}

	[Token(Token = "0x400010B")]
	public static Action OnEarlyUpdate; //Field offset: 0x0
	[Token(Token = "0x400010C")]
	public static Action OnLateUpdate; //Field offset: 0x8

	[Address(RVA = "0x1268FB0", Offset = "0x12681B0", Length = "0x325")]
	[CalledBy(Type = typeof(NetworkLoop), Member = "AddToPlayerLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateFunction), typeof(Type), typeof(PlayerLoopSystem&), typeof(Type), typeof(AddMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkLoop), Member = "RuntimeInitializeOnLoad", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NetworkLoop), Member = "AddToPlayerLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateFunction), typeof(Type), typeof(PlayerLoopSystem&), typeof(Type), typeof(AddMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "FindIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600022C")]
	internal static bool AddToPlayerLoop(UpdateFunction function, Type ownerType, ref PlayerLoopSystem playerLoop, Type playerLoopSystemType, AddMode addMode) { }

	[Address(RVA = "0x12692E0", Offset = "0x12684E0", Length = "0x1FD")]
	[CalledBy(Type = typeof(NetworkLoop), Member = "FindPlayerLoopEntryIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateFunction), typeof(PlayerLoopSystem), typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkLoop), Member = "FindPlayerLoopEntryIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateFunction), typeof(PlayerLoopSystem), typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "FindIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600022B")]
	internal static int FindPlayerLoopEntryIndex(UpdateFunction function, PlayerLoopSystem playerLoop, Type playerLoopSystemType) { }

	[Address(RVA = "0x12694E0", Offset = "0x12686E0", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "NetworkEarlyUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "NetworkEarlyUpdate", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022E")]
	private static void NetworkEarlyUpdate() { }

	[Address(RVA = "0x12695E0", Offset = "0x12687E0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022F")]
	private static void NetworkLateUpdate() { }

	[Address(RVA = "0x12696B0", Offset = "0x12688B0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x600022A")]
	private static void ResetStatics() { }

	[Address(RVA = "0x1269730", Offset = "0x1268930", Length = "0x1B1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlayerLoop), Member = "GetCurrentPlayerLoop", ReturnType = typeof(PlayerLoopSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(NetworkLoop), Member = "AddToPlayerLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateFunction), typeof(Type), typeof(PlayerLoopSystem&), typeof(Type), typeof(AddMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerLoop), Member = "SetPlayerLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x600022D")]
	private static void RuntimeInitializeOnLoad() { }

}

