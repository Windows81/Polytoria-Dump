namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000133")]
public class ECPublicKeyParameters : ECKeyParameters
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400026F")]
	private readonly ECPoint q; //Field offset: 0x30

	[Token(Token = "0x17000166")]
	public ECPoint Q
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD7")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x11E5350", Offset = "0x11E4550", Length = "0x62")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ECPublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ECPoint), typeof(ECDomainParameters)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000BD4")]
	public ECPublicKeyParameters(ECPoint q, ECDomainParameters parameters) { }

	[Address(RVA = "0x11E51F0", Offset = "0x11E43F0", Length = "0xAC")]
	[CalledBy(Type = typeof(ECPublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(ECDomainParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "GenerateKeyPair", ReturnType = typeof(AsymmetricCipherKeyPair))]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "GetCorrespondingPublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPrivateKeyParameters)}, ReturnType = typeof(ECPublicKeyParameters))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ECKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ECDomainParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ECDomainParameters), Member = "ValidatePublicPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BD5")]
	public ECPublicKeyParameters(string algorithm, ECPoint q, ECDomainParameters parameters) { }

	[Address(RVA = "0x11E52A0", Offset = "0x11E44A0", Length = "0xAC")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "GenerateKeyPair", ReturnType = typeof(AsymmetricCipherKeyPair))]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "GetCorrespondingPublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPrivateKeyParameters)}, ReturnType = typeof(ECPublicKeyParameters))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ECKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ECDomainParameters), Member = "ValidatePublicPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BD6")]
	public ECPublicKeyParameters(string algorithm, ECPoint q, DerObjectIdentifier publicKeyParamSet) { }

	[Address(RVA = "0x11E5100", Offset = "0x11E4300", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BD8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11E5070", Offset = "0x11E4270", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BD9")]
	protected bool Equals(ECPublicKeyParameters other) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BD7")]
	public ECPoint get_Q() { }

	[Address(RVA = "0x11E4E00", Offset = "0x11E4000", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BDA")]
	public virtual int GetHashCode() { }

}

