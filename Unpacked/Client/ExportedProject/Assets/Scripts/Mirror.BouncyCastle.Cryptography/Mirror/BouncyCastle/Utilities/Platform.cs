namespace Mirror.BouncyCastle.Utilities;

[Token(Token = "0x200000C")]
internal static class Platform
{
	[Token(Token = "0x4000007")]
	private static readonly CompareInfo InvariantCompareInfo; //Field offset: 0x0

	[Token(Token = "0x17000001")]
	internal static bool Is64BitProcess
	{
		[Address(RVA = "0x10BD810", Offset = "0x10BCA10", Length = "0x7")]
		[CalledBy(Type = typeof(Mod), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600003E")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x10BD770", Offset = "0x10BC970", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	private static Platform() { }

	[Address(RVA = "0x10BD550", Offset = "0x10BC750", Length = "0x8F")]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	internal static bool EndsWith(string source, string suffix) { }

	[Address(RVA = "0x10BD5E0", Offset = "0x10BC7E0", Length = "0xE")]
	[CalledBy(Type = typeof(DerInteger), Member = "AllowUnsafe", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DerInteger), Member = "IsMalformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600003B")]
	internal static bool EqualsIgnoreCase(string a, string b) { }

	[Address(RVA = "0x10BD810", Offset = "0x10BCA10", Length = "0x7")]
	[CalledBy(Type = typeof(Mod), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	internal static bool get_Is64BitProcess() { }

	[Address(RVA = "0x10BD5F0", Offset = "0x10BC7F0", Length = "0x15")]
	[CalledBy(Type = typeof(ECCurve), Member = "ImplGetInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AbstractFpCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractFpCurve), Member = "ImplCheckQ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AbstractF2mCurve), Member = "BuildField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IFiniteField))]
	[CalledBy(Type = typeof(AbstractF2mCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RsaKeyParameters), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(RsaKeyParameters), Member = "ImplGetInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DerInteger), Member = "AllowUnsafe", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DerInteger), Member = "IsMalformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600003C")]
	internal static string GetEnvironmentVariable(string variable) { }

	[Address(RVA = "0x10BD640", Offset = "0x10BC840", Length = "0x72")]
	[CalledBy(Type = typeof(DerBitString), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DerBitString))]
	[CalledBy(Type = typeof(RsaPublicKeyStructure), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RsaPublicKeyStructure))]
	[CalledBy(Type = typeof(DsaParameter), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DsaParameter))]
	[CalledBy(Type = typeof(DHValidationParms), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DHValidationParms))]
	[CalledBy(Type = typeof(DHPublicKey), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DHPublicKey))]
	[CalledBy(Type = typeof(DHDomainParameters), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DHDomainParameters))]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DerObjectIdentifier))]
	[CalledBy(Type = typeof(DerInteger), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DerInteger))]
	[CalledBy(Type = typeof(ConstructedBitStream), Member = "GetNextParser", ReturnType = typeof(Asn1BitStringParser))]
	[CalledBy(Type = typeof(ConstructedOctetStream), Member = "GetNextParser", ReturnType = typeof(Asn1OctetStringParser))]
	[CalledBy(Type = typeof(Asn1Sequence), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Asn1Sequence))]
	[CalledBy(Type = typeof(Asn1OctetString), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Asn1OctetString))]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "BuildConstructedOctetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(Asn1OctetString))]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "BuildConstructedBitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(DerBitString))]
	[CalledBy(Type = typeof(Gost28147Engine), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AesEngine), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ICipherParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PrivateKeyInfoFactory), Member = "CreatePrivateKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter), typeof(Asn1Set)}, ReturnType = typeof(PrivateKeyInfo))]
	[CalledBy(Type = typeof(SubjectPublicKeyInfoFactory), Member = "CreateSubjectPublicKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[CalledBy(Type = typeof(Asn1UniversalType), Member = "CheckedCast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Object)}, ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000040")]
	internal static string GetTypeName(object obj) { }

	[Address(RVA = "0x10BD610", Offset = "0x10BC810", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	internal static string GetTypeName(Type t) { }

	[Address(RVA = "0x10BD6C0", Offset = "0x10BC8C0", Length = "0xA2")]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "IndexOfSign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	internal static int IndexOf(string source, char value, int startIndex) { }

}

