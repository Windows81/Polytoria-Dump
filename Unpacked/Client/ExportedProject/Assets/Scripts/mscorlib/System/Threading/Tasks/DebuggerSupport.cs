namespace System.Threading.Tasks;

[Extension]
[Token(Token = "0x2000257")]
internal static class DebuggerSupport
{
	[Token(Token = "0x4000ABC")]
	private static readonly LowLevelDictionary<Int32, Task> s_activeTasks; //Field offset: 0x0
	[Token(Token = "0x4000ABD")]
	private static readonly object s_activeTasksLock; //Field offset: 0x8

	[Token(Token = "0x170001D5")]
	public static bool LoggingOn
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001352")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x1524CA0", Offset = "0x1523EA0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LowLevelDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600135C")]
	private static DebuggerSupport() { }

	[Address(RVA = "0x1524A50", Offset = "0x1523C50", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001358")]
	public static void AddToActiveTasks(Task task) { }

	[Address(RVA = "0x1524910", Offset = "0x1523B10", Length = "0x138")]
	[CalledBy(Type = typeof(DebuggerSupport), Member = "AddToActiveTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeView", Member = "remove_ItemExpanding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.EventHandler`1<VirtualizingItemExpandingArgs>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001359")]
	private static void AddToActiveTasksNonInlined(Task task) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001352")]
	public static bool get_LoggingOn() { }

	[Address(RVA = "0x1524C10", Offset = "0x1523E10", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Token(Token = "0x600135A")]
	public static void RemoveFromActiveTasks(Task task) { }

	[Address(RVA = "0x1524AE0", Offset = "0x1523CE0", Length = "0x12C")]
	[CalledBy(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeView", Member = "remove_ItemExpanding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.EventHandler`1<VirtualizingItemExpandingArgs>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelDictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600135B")]
	private static void RemoveFromActiveTasksNonInlined(Task task) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001354")]
	public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001353")]
	public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001355")]
	public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001357")]
	public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001356")]
	public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work) { }

}

