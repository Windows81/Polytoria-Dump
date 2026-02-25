namespace Mirror;

[Token(Token = "0x200008C")]
public static class ThreadLog
{
	[Token(Token = "0x200008D")]
	private struct LogEntry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D8")]
		public int threadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40001D9")]
		public LogType type; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001DA")]
		public string message; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001DB")]
		public string stackTrace; //Field offset: 0x10

		[Address(RVA = "0x128EA30", Offset = "0x128DC30", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000484")]
		public LogEntry(int threadId, LogType type, string message, string stackTrace) { }

	}

	[Token(Token = "0x40001D6")]
	private static readonly ConcurrentQueue<LogEntry> logs; //Field offset: 0x0
	[Token(Token = "0x40001D7")]
	private static int mainThreadId; //Field offset: 0x8

	[Address(RVA = "0x12A3D90", Offset = "0x12A2F90", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ThreadLog+LogEntry>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000483")]
	private static ThreadLog() { }

	[Address(RVA = "0x12A3620", Offset = "0x12A2820", Length = "0x31D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LogCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Application), Member = "remove_logMessageReceivedThreaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "add_logMessageReceivedThreaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x600047F")]
	private static void Initialize() { }

	[Address(RVA = "0x12A3940", Offset = "0x12A2B40", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000480")]
	private static bool IsMainThread() { }

	[Address(RVA = "0x12A39C0", Offset = "0x12A2BC0", Length = "0x239")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ThreadLog+LogEntry>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogEntry&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000482")]
	private static void OnLateUpdate() { }

	[Address(RVA = "0x12A3C00", Offset = "0x12A2E00", Length = "0x184")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ThreadLog+LogEntry>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000481")]
	private static void OnLog(string message, string stackTrace, LogType type) { }

}

