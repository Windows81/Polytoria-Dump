namespace UnityEngine.Bindings;

[Token(Token = "0x20001D9")]
[VisibleToOtherModules]
internal static class ExceptionMarshaller
{
	[ThreadStatic]
	[Token(Token = "0x4000677")]
	private static Exception s_pendingException; //Field offset: 0x80000000

	[Address(RVA = "0x1980D20", Offset = "0x197FF20", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000C85")]
	private static void SetPendingException(Exception ex) { }

}

