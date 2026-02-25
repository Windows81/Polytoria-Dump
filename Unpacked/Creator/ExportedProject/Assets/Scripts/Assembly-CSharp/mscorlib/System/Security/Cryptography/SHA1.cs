namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000305")]
public abstract class SHA1 : HashAlgorithm
{

	[Address(RVA = "0x133B7B0", Offset = "0x133A9B0", Length = "0x1D")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600185B")]
	protected SHA1() { }

	[Address(RVA = "0x1341F00", Offset = "0x1341100", Length = "0x44")]
	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "get_Thumbprint", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.PublicKey", "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS1", Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientHandshake", Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", "System.Uri"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerHandshake", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.BufferPool", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.TcpConfig", typeof(int), typeof(int), "Mirror.SimpleWeb.SslConfig", "Mirror.SimpleWeb.BufferPool"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA1CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600185C")]
	public static SHA1 Create() { }

}

