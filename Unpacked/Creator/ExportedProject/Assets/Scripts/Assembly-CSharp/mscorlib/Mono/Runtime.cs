namespace Mono;

[Token(Token = "0x2000030")]
public static class Runtime
{
	[Token(Token = "0x400010C")]
	private static object dump; //Field offset: 0x0

	[Address(RVA = "0x12DDFF0", Offset = "0x12DD1F0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	private static Runtime() { }

}

