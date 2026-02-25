namespace Mono.Security.X509;

[Token(Token = "0x200000B")]
internal class SafeBag
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000019")]
	private string _bagOID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001A")]
	private ASN1 _asn1; //Field offset: 0x18

	[Token(Token = "0x17000017")]
	public ASN1 ASN1
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000016")]
	public string BagOID
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000042")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public SafeBag(string bagOID, ASN1 asn1) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	public ASN1 get_ASN1() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000042")]
	public string get_BagOID() { }

}

