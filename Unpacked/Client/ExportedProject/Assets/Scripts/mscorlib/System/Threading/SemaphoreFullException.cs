namespace System.Threading;

[Token(Token = "0x20001F2")]
public class SemaphoreFullException : SystemException
{

	[Address(RVA = "0x1516380", Offset = "0x1515580", Length = "0x3C")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600110E")]
	public SemaphoreFullException() { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600110F")]
	protected SemaphoreFullException(SerializationInfo info, StreamingContext context) { }

}

