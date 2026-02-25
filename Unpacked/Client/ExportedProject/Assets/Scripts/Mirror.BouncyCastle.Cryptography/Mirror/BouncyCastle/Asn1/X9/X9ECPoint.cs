namespace Mirror.BouncyCastle.Asn1.X9;

[Token(Token = "0x2000218")]
public class X9ECPoint : Asn1Encodable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004E5")]
	private readonly Asn1OctetString encoding; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004E6")]
	private ECCurve c; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004E7")]
	private ECPoint p; //Field offset: 0x20

	[Token(Token = "0x170001A8")]
	public ECPoint Point
	{
		[Address(RVA = "0x111D700", Offset = "0x111C900", Length = "0x93")]
		[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
		[CalledBy(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[CalledBy(Type = typeof(X962NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[CalledBy(Type = typeof(X9ECParameters), Member = "get_G", ReturnType = typeof(ECPoint))]
		[CalledBy(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[CalledBy(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[CalledBy(Type = typeof(GMNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[CalledBy(Type = typeof(Frp256v1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
		[CalledBy(Type = typeof(AnssiNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600123F")]
		 get { } //Length: 147
	}

	[Address(RVA = "0x111D600", Offset = "0x111C800", Length = "0xFD")]
	[CalledBy(Type = typeof(SubjectPublicKeyInfoFactory), Member = "CreateSubjectPublicKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[CalledBy(Type = typeof(PrivateKeyInfoFactory), Member = "CreatePrivateKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter), typeof(Asn1Set)}, ReturnType = typeof(PrivateKeyInfo))]
	[CalledBy(Type = typeof(ECGost3410NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(X9ECPoint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1OctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600123C")]
	public X9ECPoint(ECPoint p, bool compressed) { }

	[Address(RVA = "0x111D4C0", Offset = "0x111C6C0", Length = "0xE9")]
	[CalledBy(Type = typeof(Frp256v1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(AnssiNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(GMNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(X9ECParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X962NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(Asn1OctetString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Asn1OctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600123D")]
	public X9ECPoint(ECCurve c, Byte[] encoding) { }

	[Address(RVA = "0x111D5B0", Offset = "0x111C7B0", Length = "0x4B")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600123E")]
	public X9ECPoint(ECCurve c, Asn1OctetString s) { }

	[Address(RVA = "0x111D700", Offset = "0x111C900", Length = "0x93")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(CustomNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(X962NamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(X9ECParameters), Member = "get_G", ReturnType = typeof(ECPoint))]
	[CalledBy(Type = typeof(TeleTrusTNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(SecNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(GMNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CalledBy(Type = typeof(Frp256v1Holder), Member = "CreateParameters", ReturnType = typeof(X9ECParameters))]
	[CalledBy(Type = typeof(AnssiNamedCurves), Member = "ConfigureBasepoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(string)}, ReturnType = typeof(X9ECPoint))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600123F")]
	public ECPoint get_Point() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001240")]
	public virtual Asn1Object ToAsn1Object() { }

}

