namespace Telepathy;

[Token(Token = "0x200000B")]
public static class Log
{
	[Token(Token = "0x400001E")]
	public static Action<String> Info; //Field offset: 0x0
	[Token(Token = "0x400001F")]
	public static Action<String> Warning; //Field offset: 0x8
	[Token(Token = "0x4000020")]
	public static Action<String> Error; //Field offset: 0x10

	[Address(RVA = "0x1802820", Offset = "0x1801A20", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000015")]
	private static Log() { }

}

