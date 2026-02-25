namespace System;

[Token(Token = "0x2000116")]
public class NotImplementedException : SystemException
{

	[Address(RVA = "0x14A4590", Offset = "0x14A3790", Length = "0x44")]
	[CallerCount(Count = 67)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008A0")]
	public NotImplementedException() { }

	[Address(RVA = "0x14A4570", Offset = "0x14A3770", Length = "0x1E")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008A1")]
	public NotImplementedException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A2")]
	protected NotImplementedException(SerializationInfo info, StreamingContext context) { }

}

