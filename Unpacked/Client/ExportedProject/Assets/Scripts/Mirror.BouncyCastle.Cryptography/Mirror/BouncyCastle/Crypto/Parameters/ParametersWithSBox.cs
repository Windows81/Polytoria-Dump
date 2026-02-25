namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000145")]
public class ParametersWithSBox : ICipherParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000292")]
	private readonly ICipherParameters m_parameters; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000293")]
	private readonly Byte[] m_sBox; //Field offset: 0x18

	[Token(Token = "0x17000176")]
	public ICipherParameters Parameters
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C2E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2C")]
	public ParametersWithSBox(ICipherParameters parameters, Byte[] sBox) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2E")]
	public ICipherParameters get_Parameters() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C2D")]
	public Byte[] GetSBox() { }

}

