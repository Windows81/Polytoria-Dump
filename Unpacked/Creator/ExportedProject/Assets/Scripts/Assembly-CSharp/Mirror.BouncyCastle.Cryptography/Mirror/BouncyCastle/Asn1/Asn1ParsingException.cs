namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001A5")]
public class Asn1ParsingException : InvalidOperationException
{

	[Address(RVA = "0x10E8B10", Offset = "0x10E7D10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F85")]
	public Asn1ParsingException() { }

	[Address(RVA = "0x10E8AF0", Offset = "0x10E7CF0", Length = "0x8")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F86")]
	public Asn1ParsingException(string message) { }

	[Address(RVA = "0x10E8B00", Offset = "0x10E7D00", Length = "0x8")]
	[CalledBy(Type = typeof(BerBitStringParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(BerOctetStringParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(DLBitStringParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F87")]
	public Asn1ParsingException(string message, Exception innerException) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F88")]
	protected Asn1ParsingException(SerializationInfo info, StreamingContext context) { }

}

