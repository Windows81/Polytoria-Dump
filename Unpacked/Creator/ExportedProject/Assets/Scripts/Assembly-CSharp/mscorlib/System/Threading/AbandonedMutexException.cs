namespace System.Threading;

[Token(Token = "0x20001E8")]
public class AbandonedMutexException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400098A")]
	private int _mutexIndex; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400098B")]
	private Mutex _mutex; //Field offset: 0x98

	[Address(RVA = "0x1508890", Offset = "0x1507A90", Length = "0x4E")]
	[CalledBy(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010FB")]
	public AbandonedMutexException() { }

	[Address(RVA = "0x15088E0", Offset = "0x1507AE0", Length = "0xC0")]
	[CalledBy(Type = typeof(WaitHandle), Member = "ThrowAbandonedMutexException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(WaitHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60010FC")]
	public AbandonedMutexException(int location, WaitHandle handle) { }

	[Address(RVA = "0x15089A0", Offset = "0x1507BA0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010FD")]
	protected AbandonedMutexException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1508800", Offset = "0x1507A00", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60010FE")]
	private void SetupException(int location, WaitHandle handle) { }

}

