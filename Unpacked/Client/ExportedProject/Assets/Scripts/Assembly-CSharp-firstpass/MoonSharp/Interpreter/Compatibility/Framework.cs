namespace MoonSharp.Interpreter.Compatibility;

[Token(Token = "0x2000196")]
public static class Framework
{
	[Token(Token = "0x4000628")]
	private static FrameworkCurrent s_FrameworkCurrent; //Field offset: 0x0

	[Token(Token = "0x170001DC")]
	public static FrameworkBase Do
	{
		[Address(RVA = "0x3968F0", Offset = "0x395AF0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000EE9")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x396860", Offset = "0x395A60", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EEA")]
	private static Framework() { }

	[Address(RVA = "0x3968F0", Offset = "0x395AF0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000EE9")]
	public static FrameworkBase get_Do() { }

}

