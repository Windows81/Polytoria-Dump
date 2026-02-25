namespace kcp2k;

[Token(Token = "0x2000012")]
public static class Log
{
	[Token(Token = "0x4000058")]
	public static Action<String> Info; //Field offset: 0x0
	[Token(Token = "0x4000059")]
	public static Action<String> Warning; //Field offset: 0x8
	[Token(Token = "0x400005A")]
	public static Action<String> Error; //Field offset: 0x10

	[Address(RVA = "0x10A3130", Offset = "0x10A2330", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600005E")]
	private static Log() { }

}

