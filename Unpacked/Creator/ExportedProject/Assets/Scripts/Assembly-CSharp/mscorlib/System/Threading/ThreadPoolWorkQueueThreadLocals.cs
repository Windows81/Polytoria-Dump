namespace System.Threading;

[Token(Token = "0x2000236")]
internal sealed class ThreadPoolWorkQueueThreadLocals
{
	[ThreadStatic]
	[Token(Token = "0x4000A4D")]
	public static ThreadPoolWorkQueueThreadLocals threadLocals; //Field offset: 0x80000000
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A4E")]
	public readonly ThreadPoolWorkQueue workQueue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A4F")]
	public readonly WorkStealingQueue workStealingQueue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A50")]
	public readonly Random random; //Field offset: 0x20

	[Address(RVA = "0x1539210", Offset = "0x1538410", Length = "0x13C")]
	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureCurrentThreadHasQueue", ReturnType = typeof(ThreadPoolWorkQueueThreadLocals))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WorkStealingQueue), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SparseArray`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001290")]
	public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq) { }

	[Address(RVA = "0x1539080", Offset = "0x1538280", Length = "0xF5")]
	[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815212B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SparseArray`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001291")]
	private void CleanUp() { }

	[Address(RVA = "0x1539180", Offset = "0x1538380", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_HasShutdownStarted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AppDomain), Member = "IsFinalizingForUnload", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "CleanUp", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001292")]
	protected virtual void Finalize() { }

}

