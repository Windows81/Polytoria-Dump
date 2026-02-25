namespace Internal.Runtime.Augments;

[Token(Token = "0x200008D")]
internal class RuntimeAugments
{
	[Token(Token = "0x4000266")]
	private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks; //Field offset: 0x0

	[Token(Token = "0x17000038")]
	internal static ReflectionExecutionDomainCallbacks Callbacks
	{
		[Address(RVA = "0x12FCB70", Offset = "0x12FBD70", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600025E")]
		internal get { } //Length: 78
	}

	[Address(RVA = "0x12FCAF0", Offset = "0x12FBCF0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600025F")]
	private static RuntimeAugments() { }

	[Address(RVA = "0x12FCB70", Offset = "0x12FBD70", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600025E")]
	internal static ReflectionExecutionDomainCallbacks get_Callbacks() { }

	[Address(RVA = "0x12FCAC0", Offset = "0x12FBCC0", Length = "0x23")]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "ThrowAsyncIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025D")]
	public static void ReportUnhandledException(Exception exception) { }

}

