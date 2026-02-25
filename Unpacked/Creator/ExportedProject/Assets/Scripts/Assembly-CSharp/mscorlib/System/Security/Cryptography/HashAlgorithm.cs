namespace System.Security.Cryptography;

[Token(Token = "0x20002DB")]
public abstract class HashAlgorithm : IDisposable, ICryptoTransform
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C9C")]
	private bool _disposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C9D")]
	protected int HashSizeValue; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C9E")]
	protected private Byte[] HashValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C9F")]
	protected int State; //Field offset: 0x20

	[Token(Token = "0x17000268")]
	public override bool CanTransformMultipleBlocks
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001785")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000265")]
	public override Byte[] Hash
	{
		[Address(RVA = "0x132BDD0", Offset = "0x132AFD0", Length = "0x108")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600177C")]
		 get { } //Length: 264
	}

	[Token(Token = "0x17000264")]
	public override int HashSize
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600177B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000266")]
	public override int InputBlockSize
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001783")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000267")]
	public override int OutputBlockSize
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001784")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001779")]
	protected HashAlgorithm() { }

	[Address(RVA = "0x132B540", Offset = "0x132A740", Length = "0xB6")]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600177F")]
	private Byte[] CaptureHashCodeAndReinitialize() { }

	[Address(RVA = "0x132B600", Offset = "0x132A800", Length = "0x3B")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message", typeof(string), typeof(string), typeof(string)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x6001781")]
	public void Clear() { }

	[Address(RVA = "0x132B640", Offset = "0x132A840", Length = "0xC7")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2_Session", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]", "System.Byte[]&", "System.Byte[]&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientHandshake", Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", "System.Uri"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.PKCS7+SignerInfo", "System.Byte[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.PKCS7+SignedData", "System.Byte[]", typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message", typeof(string), typeof(string), typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "get_Hash", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLM_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.PublicKey", "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "get_Thumbprint", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.DigestSession", Member = "HashToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600177D")]
	public Byte[] ComputeHash(Byte[] buffer) { }

	[Address(RVA = "0x132B710", Offset = "0x132A910", Length = "0x1E1")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12+DeriveBytes", Member = "Derive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "MAC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "System.Byte[]", typeof(int), "System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_Hash", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerHandshake", Member = "AcceptHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerHandshake", Member = "CreateHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x600177E")]
	public Byte[] ComputeHash(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x132B900", Offset = "0x132AB00", Length = "0x71")]
	[CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.PKCS7+SignerInfo", "System.Byte[]"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CryptoConfigForwarder), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600177A")]
	public static HashAlgorithm Create(string hashName) { }

	[Address(RVA = "0x132B990", Offset = "0x132AB90", Length = "0x61")]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerHandshake", Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001780")]
	public override void Dispose() { }

	[Address(RVA = "0x132B980", Offset = "0x132AB80", Length = "0x9")]
	[CalledBy(Type = typeof(KeyedHashAlgorithm), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MACTripleDES), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6001782")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001785")]
	public override bool get_CanTransformMultipleBlocks() { }

	[Address(RVA = "0x132BDD0", Offset = "0x132AFD0", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600177C")]
	public override Byte[] get_Hash() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600177B")]
	public override int get_HashSize() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001783")]
	public override int get_InputBlockSize() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001784")]
	public override int get_OutputBlockSize() { }

	[Token(Token = "0x6001789")]
	protected abstract void HashCore(Byte[] array, int ibStart, int cbSize) { }

	[Token(Token = "0x600178A")]
	protected abstract Byte[] HashFinal() { }

	[Token(Token = "0x600178B")]
	public abstract void Initialize() { }

	[Address(RVA = "0x132BA00", Offset = "0x132AC00", Length = "0xA1")]
	[CalledBy(Type = "Mono.Security.X509.PKCS12+DeriveBytes", Member = "Derive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeBase", Member = "GetHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(HashAlgorithm), Member = "ValidateTransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001786")]
	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[Address(RVA = "0x132BAB0", Offset = "0x132ACB0", Length = "0x156")]
	[CalledBy(Type = typeof(HMAC), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12+DeriveBytes", Member = "Derive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeBase", Member = "GetHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(HashAlgorithm), Member = "ValidateTransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001787")]
	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	[Address(RVA = "0x132BC10", Offset = "0x132AE10", Length = "0x1BC")]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(HMAC), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HMAC), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001788")]
	private void ValidateTransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

