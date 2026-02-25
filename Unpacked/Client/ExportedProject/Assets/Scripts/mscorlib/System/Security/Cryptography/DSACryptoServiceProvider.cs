namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200031A")]
public sealed class DSACryptoServiceProvider : DSA
{
	[Token(Token = "0x4000D50")]
	private static bool useMachineKeyStore; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D4A")]
	private KeyPairPersistence store; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D4B")]
	private bool persistKey; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000D4C")]
	private bool persisted; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000D4D")]
	private bool privateKeyExportable; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x4000D4E")]
	private bool m_disposed; //Field offset: 0x2B
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D4F")]
	private DSAManaged dsa; //Field offset: 0x30

	[Token(Token = "0x17000295")]
	public virtual int KeySize
	{
		[Address(RVA = "0x134A3E0", Offset = "0x13495E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018F4")]
		 get { } //Length: 42
	}

	[ComVisible(False)]
	[Token(Token = "0x17000296")]
	public bool PublicOnly
	{
		[Address(RVA = "0x134A410", Offset = "0x1349610", Length = "0x1D")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60018F5")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x134A3B0", Offset = "0x13495B0", Length = "0x2C")]
	[CalledBy(Type = typeof(DSA), Member = "Create", ReturnType = typeof(DSA))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018F0")]
	public DSACryptoServiceProvider() { }

	[Address(RVA = "0x134A370", Offset = "0x1349570", Length = "0x34")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeDSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "System.Byte[]"}, ReturnType = typeof(DSA))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_DSA", ReturnType = typeof(DSA))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018F1")]
	public DSACryptoServiceProvider(int dwKeySize) { }

	[Address(RVA = "0x1349FA0", Offset = "0x13491A0", Length = "0x236")]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyPairPersistence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CspProviderFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CspParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DSAManaged), Member = "add_KeyGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyGeneratedEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DSAManaged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60018F2")]
	private void Common(int dwKeySize, bool parameters) { }

	[Address(RVA = "0x133BB60", Offset = "0x133AD60", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyPairPersistence), Member = "Remove", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018F9")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x134A1E0", Offset = "0x13493E0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60018F6")]
	public virtual DSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x12D1B30", Offset = "0x12D0D30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018F3")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x134A3E0", Offset = "0x13495E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018F4")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x134A410", Offset = "0x1349610", Length = "0x1D")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60018F5")]
	public bool get_PublicOnly() { }

	[Address(RVA = "0x133BF30", Offset = "0x133B130", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018F7")]
	public virtual void ImportParameters(DSAParameters parameters) { }

	[Address(RVA = "0x134A2B0", Offset = "0x13494B0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyPairPersistence), Member = "set_KeyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60018FA")]
	private void OnKeyGenerated(object sender, EventArgs e) { }

	[Address(RVA = "0x134A340", Offset = "0x1349540", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60018F8")]
	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

