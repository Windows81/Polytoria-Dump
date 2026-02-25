namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000034")]
public static class NtlmSettings
{
	[Token(Token = "0x40000A3")]
	private static NtlmAuthLevel defaultAuthLevel; //Field offset: 0x0

	[Token(Token = "0x17000055")]
	public static NtlmAuthLevel DefaultAuthLevel
	{
		[Address(RVA = "0x12CDC10", Offset = "0x12CCE10", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000128")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x12CDBD0", Offset = "0x12CCDD0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000129")]
	private static NtlmSettings() { }

	[Address(RVA = "0x12CDC10", Offset = "0x12CCE10", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000128")]
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

}

