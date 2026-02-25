namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000144")]
public class ParametersWithRandom : ICipherParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000291")]
	private readonly ICipherParameters m_parameters; //Field offset: 0x10

	[Token(Token = "0x17000175")]
	public ICipherParameters Parameters
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C2B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2B")]
	public ICipherParameters get_Parameters() { }

}

