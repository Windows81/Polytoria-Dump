namespace System.Threading;

[Token(Token = "0x20001F8")]
public class ThreadStateException : SystemException
{

	[Address(RVA = "0x151AAB0", Offset = "0x1519CB0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001117")]
	public ThreadStateException() { }

	[Address(RVA = "0x151AA90", Offset = "0x1519C90", Length = "0x1E")]
	[CalledBy(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = "ValidateThreadState", ReturnType = typeof(ThreadState))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001118")]
	public ThreadStateException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001119")]
	protected ThreadStateException(SerializationInfo info, StreamingContext context) { }

}

