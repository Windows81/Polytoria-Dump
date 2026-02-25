namespace System.Threading;

[Token(Token = "0x20001F4")]
public class SynchronizationLockException : SystemException
{

	[Address(RVA = "0x15198E0", Offset = "0x1518AE0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001112")]
	public SynchronizationLockException() { }

	[Address(RVA = "0x15198C0", Offset = "0x1518AC0", Length = "0x1E")]
	[CalledBy(Type = typeof(Monitor), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "CancellationTokenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "CancellationTokenCanceledEventHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Monitor), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Monitor), Member = "Pulse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Monitor), Member = "PulseAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Monitor), Member = "ObjPulse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Monitor), Member = "ObjPulseAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Monitor), Member = "ObjWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "ExitReadLock", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001113")]
	public SynchronizationLockException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001114")]
	protected SynchronizationLockException(SerializationInfo info, StreamingContext context) { }

}

