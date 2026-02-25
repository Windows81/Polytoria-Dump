namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
[Token(Token = "0x2000089")]
internal sealed class DebugLogHandler : ILogHandler
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000247")]
	public DebugLogHandler() { }

	[Address(RVA = "0x1924B30", Offset = "0x1923D30", Length = "0x1B4")]
	[CalledBy(Type = typeof(DebugLogHandler), Member = "LogFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugLogHandler), Member = "LogFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogOption), typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Debug), Member = "LogFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogOption), typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000242")]
	internal static void Internal_Log(LogType level, LogOption options, string msg, object obj) { }

	[Address(RVA = "0x1924AD0", Offset = "0x1923CD0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000248")]
	private static void Internal_Log_Injected(LogType level, LogOption options, ref ManagedSpanWrapper msg, IntPtr obj) { }

	[Address(RVA = "0x1924A50", Offset = "0x1923C50", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000243")]
	internal static void Internal_LogException(Exception ex, object obj) { }

	[Address(RVA = "0x1924A00", Offset = "0x1923C00", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000249")]
	private static void Internal_LogException_Injected(Exception ex, IntPtr obj) { }

	[Address(RVA = "0x1924CF0", Offset = "0x1923EF0", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000246")]
	public override void LogException(Exception exception, object context) { }

	[Address(RVA = "0x1924DC0", Offset = "0x1923FC0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DebugLogHandler), Member = "Internal_Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogOption), typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000244")]
	public override void LogFormat(LogType logType, object context, string format, Object[] args) { }

	[Address(RVA = "0x1924E10", Offset = "0x1924010", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DebugLogHandler), Member = "Internal_Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogOption), typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000245")]
	public void LogFormat(LogType logType, LogOption logOptions, object context, string format, Object[] args) { }

}

