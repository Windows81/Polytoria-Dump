namespace System.Runtime.InteropServices;

[Token(Token = "0x200042D")]
public class MarshalDirectiveException : SystemException
{

	[Address(RVA = "0x13BAE30", Offset = "0x13BA030", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001F4E")]
	public MarshalDirectiveException() { }

	[Address(RVA = "0x13BAE80", Offset = "0x13BA080", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001F4F")]
	public MarshalDirectiveException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F50")]
	protected MarshalDirectiveException(SerializationInfo info, StreamingContext context) { }

}

