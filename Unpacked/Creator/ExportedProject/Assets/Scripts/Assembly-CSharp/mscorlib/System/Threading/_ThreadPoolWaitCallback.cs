namespace System.Threading;

[Token(Token = "0x2000237")]
internal static class _ThreadPoolWaitCallback
{

	[Address(RVA = "0x153D170", Offset = "0x153C370", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
	[Token(Token = "0x6001293")]
	internal static bool PerformWaitCallback() { }

}

