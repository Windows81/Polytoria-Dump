namespace Mirror.BouncyCastle.Asn1.X9;

[Token(Token = "0x2000214")]
public class X9Curve : Asn1Encodable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004D7")]
	private readonly ECCurve curve; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004D8")]
	private readonly Byte[] seed; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004D9")]
	private readonly DerObjectIdentifier fieldIdentifier; //Field offset: 0x20

	[Token(Token = "0x170001A1")]
	public ECCurve Curve
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001226")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x111BED0", Offset = "0x111B0D0", Length = "0x1B5")]
	[CalledBy(Type = typeof(X9ECParameters), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ECAlgorithms), Member = "IsFpCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ECAlgorithms), Member = "IsF2mCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001224")]
	public X9Curve(ECCurve curve, Byte[] seed) { }

	[Address(RVA = "0x111B580", Offset = "0x111A780", Length = "0x94A")]
	[CalledBy(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(FpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerInteger), Member = "get_Value", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(F2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Asn1OctetString), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Asn1OctetString))]
	[Calls(Type = typeof(DerInteger), Member = "get_IntValueExact", ReturnType = typeof(int))]
	[Calls(Type = typeof(Asn1Object), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[Token(Token = "0x6001225")]
	public X9Curve(X9FieldID fieldID, BigInteger order, BigInteger cofactor, Asn1Sequence seq) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001226")]
	public ECCurve get_Curve() { }

	[Address(RVA = "0x111B2A0", Offset = "0x111A4A0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6001227")]
	public Byte[] GetSeed() { }

	[Address(RVA = "0x111B2F0", Offset = "0x111A4F0", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1EncodableVector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1Object), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Asn1EncodableVector), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1Sequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001228")]
	public virtual Asn1Object ToAsn1Object() { }

}

