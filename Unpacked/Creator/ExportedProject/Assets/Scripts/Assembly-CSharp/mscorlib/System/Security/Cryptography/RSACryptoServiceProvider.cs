namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000304")]
public sealed class RSACryptoServiceProvider : RSA
{
	[Token(Token = "0x4000D10")]
	private static CspProviderFlags s_UseMachineKeyStore; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D11")]
	private KeyPairPersistence store; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D12")]
	private bool persistKey; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000D13")]
	private bool persisted; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000D14")]
	private bool privateKeyExportable; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x4000D15")]
	private bool m_disposed; //Field offset: 0x2B
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D16")]
	private RSAManaged rsa; //Field offset: 0x30

	[Token(Token = "0x17000284")]
	public virtual int KeySize
	{
		[Address(RVA = "0x133C600", Offset = "0x133B800", Length = "0x23")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001852")]
		 get { } //Length: 35
	}

	[ComVisible(False)]
	[Token(Token = "0x17000285")]
	public bool PublicOnly
	{
		[Address(RVA = "0x133C630", Offset = "0x133B830", Length = "0x1D")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001853")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000283")]
	public static bool UseMachineKeyStore
	{
		[Address(RVA = "0x133C650", Offset = "0x133B850", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600184A")]
		 get { } //Length: 67
	}

	[Address(RVA = "0x133C5D0", Offset = "0x133B7D0", Length = "0x2C")]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600184B")]
	public RSACryptoServiceProvider() { }

	[Address(RVA = "0x133C480", Offset = "0x133B680", Length = "0x146")]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS8+PrivateKeyInfo", Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(RSA))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600184C")]
	public RSACryptoServiceProvider(CspParameters parameters) { }

	[Address(RVA = "0x133C2F0", Offset = "0x133B4F0", Length = "0x34")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(RSA))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_RSA", ReturnType = typeof(RSA))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600184D")]
	public RSACryptoServiceProvider(int dwKeySize) { }

	[Address(RVA = "0x133C330", Offset = "0x133B530", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600184E")]
	public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters) { }

	[Address(RVA = "0x133B7D0", Offset = "0x133A9D0", Length = "0x25C")]
	[CalledBy(Type = typeof(RSA), Member = "Create", ReturnType = typeof(RSA))]
	[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CspParameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspProviderFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CspParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RSAManaged), Member = "add_KeyGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyGeneratedEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RSAManaged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600184F")]
	private void Common(int dwKeySize, bool parameters) { }

	[Address(RVA = "0x133BA30", Offset = "0x133AC30", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001850")]
	private void Common(CspParameters p) { }

	[Address(RVA = "0x133BB60", Offset = "0x133AD60", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyPairPersistence), Member = "Remove", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001859")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x133BBB0", Offset = "0x133ADB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001854")]
	public virtual Byte[] EncryptValue(Byte[] rgb) { }

	[Address(RVA = "0x133BBE0", Offset = "0x133ADE0", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001855")]
	public virtual RSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x12D1B30", Offset = "0x12D0D30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001851")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x133C600", Offset = "0x133B800", Length = "0x23")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001852")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x133C630", Offset = "0x133B830", Length = "0x1D")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001853")]
	public bool get_PublicOnly() { }

	[Address(RVA = "0x133C650", Offset = "0x133B850", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600184A")]
	public static bool get_UseMachineKeyStore() { }

	[Address(RVA = "0x133BD80", Offset = "0x133AF80", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6001857")]
	private string GetHashNameFromOID(string oid) { }

	[Address(RVA = "0x133BF30", Offset = "0x133B130", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001856")]
	public virtual void ImportParameters(RSAParameters parameters) { }

	[Address(RVA = "0x133BF90", Offset = "0x133B190", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyPairPersistence), Member = "set_KeyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600185A")]
	private void OnKeyGenerated(object sender, EventArgs e) { }

	[Address(RVA = "0x133C020", Offset = "0x133B220", Length = "0x2C8")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.PKCS7+SignedData", "System.Byte[]", typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA), typeof(HashAlgorithm), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6001858")]
	public bool VerifyHash(Byte[] rgbHash, string str, Byte[] rgbSignature) { }

}

