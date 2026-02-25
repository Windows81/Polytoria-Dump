namespace Mirror.BouncyCastle.Crypto.Agreement;

[Token(Token = "0x2000197")]
public class ECDHBasicAgreement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400041D")]
	protected private ECPrivateKeyParameters privKey; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F08")]
	public ECDHBasicAgreement() { }

	[Address(RVA = "0x10F1480", Offset = "0x10F0680", Length = "0x321")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ECAlgorithms), Member = "ReferenceMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(BigInteger)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(BigInteger), Member = "Mod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ECDomainParameters), Member = "get_HInv", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ECAlgorithms), Member = "CleanPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000F07")]
	public override BigInteger CalculateAgreement(ICipherParameters pubKey) { }

	[Address(RVA = "0x10F17B0", Offset = "0x10F09B0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F06")]
	public override void Init(ICipherParameters parameters) { }

}

