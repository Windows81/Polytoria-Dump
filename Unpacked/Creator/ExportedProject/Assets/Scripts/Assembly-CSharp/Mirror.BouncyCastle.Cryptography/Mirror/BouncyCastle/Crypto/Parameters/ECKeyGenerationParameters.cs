namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x200012F")]
public class ECKeyGenerationParameters : KeyGenerationParameters
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000267")]
	private readonly ECDomainParameters domainParams; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000268")]
	private readonly DerObjectIdentifier publicKeyParamSet; //Field offset: 0x28

	[Token(Token = "0x1700015F")]
	public ECDomainParameters DomainParameters
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000160")]
	public DerObjectIdentifier PublicKeyParamSet
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBE")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBD")]
	public ECDomainParameters get_DomainParameters() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBE")]
	public DerObjectIdentifier get_PublicKeyParamSet() { }

}

