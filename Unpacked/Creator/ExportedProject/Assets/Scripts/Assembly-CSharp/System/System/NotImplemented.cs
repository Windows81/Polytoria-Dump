namespace System;

[Token(Token = "0x20000B5")]
internal static class NotImplemented
{

	[Address(RVA = "0x17436E0", Offset = "0x17428E0", Length = "0x54")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000373")]
	internal static Exception ByDesignWithMessage(string message) { }

}

