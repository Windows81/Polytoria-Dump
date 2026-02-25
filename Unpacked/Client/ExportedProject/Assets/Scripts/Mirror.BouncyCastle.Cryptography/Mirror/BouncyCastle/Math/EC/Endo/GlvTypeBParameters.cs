namespace Mirror.BouncyCastle.Math.EC.Endo;

[Token(Token = "0x200007E")]
public class GlvTypeBParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000127")]
	protected readonly BigInteger m_beta; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000128")]
	protected readonly BigInteger m_lambda; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000129")]
	protected readonly ScalarSplitParameters m_splitParams; //Field offset: 0x20

	[Token(Token = "0x17000059")]
	public override BigInteger Beta
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600046A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005A")]
	public override ScalarSplitParameters SplitParams
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600046B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1013590", Offset = "0x1012790", Length = "0x6B")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000469")]
	public GlvTypeBParameters(BigInteger beta, BigInteger lambda, ScalarSplitParameters splitParams) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046A")]
	public override BigInteger get_Beta() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046B")]
	public override ScalarSplitParameters get_SplitParams() { }

}

