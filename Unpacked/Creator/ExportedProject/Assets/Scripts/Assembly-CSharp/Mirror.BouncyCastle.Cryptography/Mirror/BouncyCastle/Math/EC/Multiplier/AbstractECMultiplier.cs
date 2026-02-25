namespace Mirror.BouncyCastle.Math.EC.Multiplier;

[Token(Token = "0x2000065")]
public abstract class AbstractECMultiplier : ECMultiplier
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000405")]
	protected AbstractECMultiplier() { }

	[Address(RVA = "0x1155400", Offset = "0x1154600", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ECAlgorithms), Member = "ImplCheckResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[Token(Token = "0x6000404")]
	protected override ECPoint CheckResult(ECPoint p) { }

	[Address(RVA = "0x1155410", Offset = "0x1154610", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "Abs", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000402")]
	public override ECPoint Multiply(ECPoint p, BigInteger k) { }

	[Token(Token = "0x6000403")]
	protected abstract ECPoint MultiplyPositive(ECPoint p, BigInteger k) { }

}

