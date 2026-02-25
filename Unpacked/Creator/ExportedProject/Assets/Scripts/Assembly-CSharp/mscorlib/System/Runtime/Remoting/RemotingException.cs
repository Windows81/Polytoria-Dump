namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000345")]
public class RemotingException : SystemException
{

	[Address(RVA = "0x1337610", Offset = "0x1336810", Length = "0x7")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A28")]
	public RemotingException() { }

	[Address(RVA = "0x136EB70", Offset = "0x136DD70", Length = "0x8")]
	[CallerCount(Count = 60)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A29")]
	public RemotingException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A2A")]
	protected RemotingException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x136EB60", Offset = "0x136DD60", Length = "0x8")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A2B")]
	public RemotingException(string message, Exception InnerException) { }

}

