namespace System.Threading;

[Token(Token = "0x2000200")]
internal static class PlatformHelper
{
	[Token(Token = "0x40009B3")]
	private static int s_processorCount; //Field offset: 0x0
	[Token(Token = "0x40009B4")]
	private static int s_lastProcessorCountRefreshTicks; //Field offset: 0x4
	[Token(Token = "0x40009B5")]
	internal static readonly bool IsSingleProcessor; //Field offset: 0x8

	[Token(Token = "0x17000197")]
	internal static int ProcessorCount
	{
		[Address(RVA = "0x1516010", Offset = "0x1515210", Length = "0x106")]
		[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.ReaderWriterLockSlim+TimeoutTracker"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PlatformHelper), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CancellationTokenSource), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "get_DefaultConcurrencyLevel", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "EnterMyLockSpin", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001151")]
		internal get { } //Length: 262
	}

	[Address(RVA = "0x1515FC0", Offset = "0x15151C0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001152")]
	private static PlatformHelper() { }

	[Address(RVA = "0x1516010", Offset = "0x1515210", Length = "0x106")]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "get_DefaultConcurrencyLevel", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "EnterMyLockSpin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlatformHelper), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.ReaderWriterLockSlim+TimeoutTracker"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6001151")]
	internal static int get_ProcessorCount() { }

}

