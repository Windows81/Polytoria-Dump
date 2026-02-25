namespace Mirror.BouncyCastle.Asn1.CryptoPro;

[Token(Token = "0x2000270")]
public class Gost3410ParamSetParameters : Asn1Encodable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007AE")]
	private readonly int keySize; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007AF")]
	private readonly DerInteger p; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007B0")]
	private readonly DerInteger q; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007B1")]
	private readonly DerInteger a; //Field offset: 0x28

	[Token(Token = "0x170001C6")]
	public BigInteger A
	{
		[Address(RVA = "0x1126120", Offset = "0x1125320", Length = "0x1D")]
		[CalledBy(Type = typeof(Gost3410KeyParameters), Member = "LookupParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(Gost3410Parameters))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013A1")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170001C4")]
	public BigInteger P
	{
		[Address(RVA = "0x1121860", Offset = "0x1120A60", Length = "0x1D")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600139F")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170001C5")]
	public BigInteger Q
	{
		[Address(RVA = "0x1126140", Offset = "0x1125340", Length = "0x1D")]
		[CalledBy(Type = typeof(Gost3410KeyParameters), Member = "LookupParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(Gost3410Parameters))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013A0")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x1126030", Offset = "0x1125230", Length = "0xE5")]
	[CalledBy(Type = typeof(Gost3410NamedParameters), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600139E")]
	public Gost3410ParamSetParameters(int keySize, BigInteger p, BigInteger q, BigInteger a) { }

	[Address(RVA = "0x1126120", Offset = "0x1125320", Length = "0x1D")]
	[CalledBy(Type = typeof(Gost3410KeyParameters), Member = "LookupParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(Gost3410Parameters))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013A1")]
	public BigInteger get_A() { }

	[Address(RVA = "0x1121860", Offset = "0x1120A60", Length = "0x1D")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600139F")]
	public BigInteger get_P() { }

	[Address(RVA = "0x1126140", Offset = "0x1125340", Length = "0x1D")]
	[CalledBy(Type = typeof(Gost3410KeyParameters), Member = "LookupParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(Gost3410Parameters))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013A0")]
	public BigInteger get_Q() { }

	[Address(RVA = "0x1125E40", Offset = "0x1125040", Length = "0x1EF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DerSequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60013A2")]
	public virtual Asn1Object ToAsn1Object() { }

}

