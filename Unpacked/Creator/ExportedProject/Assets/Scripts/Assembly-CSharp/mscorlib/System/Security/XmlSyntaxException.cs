namespace System.Security;

[Token(Token = "0x20002C0")]
public sealed class XmlSyntaxException : SystemException
{

	[Address(RVA = "0x1337610", Offset = "0x1336810", Length = "0x7")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60016EE")]
	public XmlSyntaxException() { }

	[Address(RVA = "0x1337610", Offset = "0x1336810", Length = "0x7")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60016EF")]
	public XmlSyntaxException(int lineNumber) { }

	[Address(RVA = "0x1337610", Offset = "0x1336810", Length = "0x7")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60016F0")]
	public XmlSyntaxException(int lineNumber, string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016F1")]
	private XmlSyntaxException(SerializationInfo info, StreamingContext context) { }

}

