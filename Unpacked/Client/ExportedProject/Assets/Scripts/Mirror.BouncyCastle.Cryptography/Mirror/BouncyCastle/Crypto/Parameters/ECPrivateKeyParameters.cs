namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000132")]
public class ECPrivateKeyParameters : ECKeyParameters
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400026E")]
	private readonly BigInteger d; //Field offset: 0x30

	[Token(Token = "0x17000165")]
	public BigInteger D
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD0")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x11E4EA0", Offset = "0x11E40A0", Length = "0x62")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ECPrivateKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BigInteger), typeof(ECDomainParameters)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000BCD")]
	public ECPrivateKeyParameters(BigInteger d, ECDomainParameters parameters) { }

	[Address(RVA = "0x11E4FC0", Offset = "0x11E41C0", Length = "0xA8")]
	[CalledBy(Type = typeof(ECPrivateKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ECDomainParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "GenerateKeyPair", ReturnType = typeof(AsymmetricCipherKeyPair))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ECKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ECDomainParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ECDomainParameters), Member = "ValidatePrivateScalar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BCE")]
	public ECPrivateKeyParameters(string algorithm, BigInteger d, ECDomainParameters parameters) { }

	[Address(RVA = "0x11E4F10", Offset = "0x11E4110", Length = "0xA8")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ECKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ECDomainParameters), Member = "ValidatePrivateScalar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BCF")]
	public ECPrivateKeyParameters(string algorithm, BigInteger d, DerObjectIdentifier publicKeyParamSet) { }

	[Address(RVA = "0x11E4CA0", Offset = "0x11E3EA0", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BD1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11E4D80", Offset = "0x11E3F80", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BD2")]
	protected bool Equals(ECPrivateKeyParameters other) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BD0")]
	public BigInteger get_D() { }

	[Address(RVA = "0x11E4E00", Offset = "0x11E4000", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BD3")]
	public virtual int GetHashCode() { }

}

