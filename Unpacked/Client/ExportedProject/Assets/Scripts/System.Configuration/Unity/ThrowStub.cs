namespace Unity;

[Token(Token = "0x200000A")]
internal sealed class ThrowStub : ObjectDisposedException
{

	[Address(RVA = "0x156AA90", Offset = "0x1569C90", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000011")]
	public static void ThrowNotSupportedException() { }

}

