namespace System.Threading;

[Token(Token = "0x2000231")]
internal static class ThreadPoolGlobals
{
	[Token(Token = "0x4000A3C")]
	public static int processorCount; //Field offset: 0x0
	[Token(Token = "0x4000A3D")]
	public static bool vmTpInitialized; //Field offset: 0x4
	[Token(Token = "0x4000A3E")]
	public static bool enableWorkerTracking; //Field offset: 0x5
	[Token(Token = "0x4000A3F")]
	public static readonly ThreadPoolWorkQueue workQueue; //Field offset: 0x8

	[Address(RVA = "0x1519E70", Offset = "0x1519070", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(QueueSegment), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001276")]
	private static ThreadPoolGlobals() { }

}

