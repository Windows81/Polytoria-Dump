namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x200019B")]
public class Asn1Exception : IOException
{

	[Address(RVA = "0x10E3030", Offset = "0x10E2230", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IOException), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000F27")]
	public Asn1Exception() { }

	[Address(RVA = "0x10E3020", Offset = "0x10E2220", Length = "0x8")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "BuildConstructedBitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(DerBitString))]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "BuildConstructedOctetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(Asn1OctetString))]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "ParseImplicitConstructedDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Convertible))]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "ParseImplicitConstructedIL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Convertible))]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "ParseImplicitPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefiniteLengthInputStream)}, ReturnType = typeof(IAsn1Convertible))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F28")]
	public Asn1Exception(string message) { }

	[Address(RVA = "0x10E3040", Offset = "0x10E2240", Length = "0x8")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "ReadObject", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "ParseImplicitPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefiniteLengthInputStream)}, ReturnType = typeof(IAsn1Convertible))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F29")]
	public Asn1Exception(string message, Exception innerException) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F2A")]
	protected Asn1Exception(SerializationInfo info, StreamingContext context) { }

}

