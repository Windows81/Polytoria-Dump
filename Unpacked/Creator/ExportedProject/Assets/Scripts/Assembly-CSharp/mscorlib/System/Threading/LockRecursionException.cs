namespace System.Threading;

[Token(Token = "0x20001EF")]
public class LockRecursionException : Exception
{

	[Address(RVA = "0x1513470", Offset = "0x1512670", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001108")]
	public LockRecursionException() { }

	[Address(RVA = "0x15134C0", Offset = "0x15126C0", Length = "0x59")]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.ReaderWriterLockSlim+TimeoutTracker"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001109")]
	public LockRecursionException(string message) { }

	[Address(RVA = "0x15133F0", Offset = "0x15125F0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Token(Token = "0x600110A")]
	protected LockRecursionException(SerializationInfo info, StreamingContext context) { }

}

