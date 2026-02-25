namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002E3")]
public class CryptographicException : SystemException
{

	[Address(RVA = "0x1322550", Offset = "0x1321750", Length = "0x56")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsObject", Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsProvider", Member = "CheckValidationResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Net.Security.ChainValidationHelper", typeof(string), typeof(bool), "System.Security.Cryptography.X509Certificates.X509CertificateCollection", typeof(bool), "System.Security.Cryptography.X509Certificates.X509Chain", "Mono.Btls.MonoBtlsX509StoreCtx", typeof(bool), "System.Net.Security.SslPolicyErrors&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60017A3")]
	public CryptographicException() { }

	[Address(RVA = "0x13225D0", Offset = "0x13217D0", Length = "0x26")]
	[CallerCount(Count = 179)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017A4")]
	public CryptographicException(string message) { }

	[Address(RVA = "0x1322490", Offset = "0x1321690", Length = "0x8E")]
	[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(SymmetricTransform), Member = "TransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DES), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(TripleDES), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = "Mono.Security.ASN1")]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS8+PrivateKeyInfo", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017A5")]
	public CryptographicException(string format, string insert) { }

	[Address(RVA = "0x1322520", Offset = "0x1321720", Length = "0x26")]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsObject", Member = "CheckLastError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(SafePasswordHandle), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeDSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "System.Byte[]"}, ReturnType = typeof(DSA))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(RSA))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017A6")]
	public CryptographicException(string message, Exception inner) { }

	[Address(RVA = "0x1322430", Offset = "0x1321630", Length = "0x5A")]
	[CalledBy(Type = typeof(X509Certificate), Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Win32Native), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60017A7")]
	public CryptographicException(int hr) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017A8")]
	protected CryptographicException(SerializationInfo info, StreamingContext context) { }

}

