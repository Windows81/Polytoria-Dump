namespace UnityEngine;

[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
[Token(Token = "0x20000F2")]
internal class UnityLogWriter : TextWriter
{

	[Token(Token = "0x1700012D")]
	public virtual Encoding Encoding
	{
		[Address(RVA = "0x1956F80", Offset = "0x1956180", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Token(Token = "0x60006D4")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1956F30", Offset = "0x1956130", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60006D8")]
	public UnityLogWriter() { }

	[Address(RVA = "0x1956F80", Offset = "0x1956180", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Token(Token = "0x60006D4")]
	public virtual Encoding get_Encoding() { }

	[Address(RVA = "0x1956C00", Offset = "0x1955E00", Length = "0xD4")]
	[CalledBy(Type = typeof(ClassLibraryInitializer), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(TextWriter))]
	[Calls(Type = typeof(Console), Member = "SetOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "SetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006D3")]
	public static void Init() { }

	[Address(RVA = "0x1956EC0", Offset = "0x19560C0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLogImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006D5")]
	public virtual void Write(char value) { }

	[Address(RVA = "0x1956EA0", Offset = "0x19560A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLogImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006D6")]
	public virtual void Write(string s) { }

	[Address(RVA = "0x1956F00", Offset = "0x1956100", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLogImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006D7")]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1956E90", Offset = "0x1956090", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLogImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60006D1")]
	public static void WriteStringToUnityLog(string s) { }

	[Address(RVA = "0x1956D20", Offset = "0x1955F20", Length = "0x16A")]
	[CalledBy(Type = typeof(UnityLogWriter), Member = "WriteStringToUnityLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityLogWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityLogWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityLogWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60006D2")]
	private static void WriteStringToUnityLogImpl(string s) { }

	[Address(RVA = "0x1956CE0", Offset = "0x1955EE0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006D9")]
	private static void WriteStringToUnityLogImpl_Injected(ref ManagedSpanWrapper s) { }

}

