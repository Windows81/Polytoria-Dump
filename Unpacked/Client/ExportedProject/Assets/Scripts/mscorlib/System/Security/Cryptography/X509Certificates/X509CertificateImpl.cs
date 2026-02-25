namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000327")]
internal abstract class X509CertificateImpl : IDisposable
{

	[Token(Token = "0x170002A6")]
	public abstract bool HasPrivateKey
	{
		[Token(Token = "0x6001963")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029C")]
	public abstract string Issuer
	{
		[Token(Token = "0x6001958")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029B")]
	public abstract bool IsValid
	{
		[Token(Token = "0x6001955")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A2")]
	public abstract string KeyAlgorithm
	{
		[Token(Token = "0x600195F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A3")]
	public abstract Byte[] KeyAlgorithmParameters
	{
		[Token(Token = "0x6001960")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029F")]
	public abstract DateTime NotAfter
	{
		[Token(Token = "0x600195B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A0")]
	public abstract DateTime NotBefore
	{
		[Token(Token = "0x600195C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A4")]
	public abstract Byte[] PublicKeyValue
	{
		[Token(Token = "0x6001961")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029E")]
	public abstract Byte[] RawData
	{
		[Token(Token = "0x600195A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A5")]
	public abstract Byte[] SerialNumber
	{
		[Token(Token = "0x6001962")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029D")]
	public abstract string Subject
	{
		[Token(Token = "0x6001959")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A1")]
	public abstract Byte[] Thumbprint
	{
		[Token(Token = "0x600195D")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600196B")]
	protected X509CertificateImpl() { }

	[Token(Token = "0x6001957")]
	public abstract X509CertificateImpl Clone() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001969")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x13549E0", Offset = "0x1353BE0", Length = "0x61")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImplCollection", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001968")]
	public override void Dispose() { }

	[Address(RVA = "0x1354A50", Offset = "0x1353C50", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6001967")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x6001966")]
	public abstract Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	[Address(RVA = "0x1354BF0", Offset = "0x1353DF0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600196A")]
	protected virtual void Finalize() { }

	[Token(Token = "0x6001963")]
	public abstract bool get_HasPrivateKey() { }

	[Token(Token = "0x6001958")]
	public abstract string get_Issuer() { }

	[Token(Token = "0x6001955")]
	public abstract bool get_IsValid() { }

	[Token(Token = "0x600195F")]
	public abstract string get_KeyAlgorithm() { }

	[Token(Token = "0x6001960")]
	public abstract Byte[] get_KeyAlgorithmParameters() { }

	[Token(Token = "0x600195B")]
	public abstract DateTime get_NotAfter() { }

	[Token(Token = "0x600195C")]
	public abstract DateTime get_NotBefore() { }

	[Token(Token = "0x6001961")]
	public abstract Byte[] get_PublicKeyValue() { }

	[Token(Token = "0x600195A")]
	public abstract Byte[] get_RawData() { }

	[Token(Token = "0x6001962")]
	public abstract Byte[] get_SerialNumber() { }

	[Token(Token = "0x6001959")]
	public abstract string get_Subject() { }

	[Token(Token = "0x600195D")]
	public abstract Byte[] get_Thumbprint() { }

	[Token(Token = "0x6001965")]
	public abstract DSA GetDSAPrivateKey() { }

	[Address(RVA = "0x1354C60", Offset = "0x1353E60", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600195E")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6001964")]
	public abstract RSA GetRSAPrivateKey() { }

	[Address(RVA = "0x1354CF0", Offset = "0x1353EF0", Length = "0x4B")]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "get_X509", ReturnType = "Mono.Btls.MonoBtlsX509")]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "get_NativePrivateKey", ReturnType = "Mono.Btls.MonoBtlsKey")]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "Clone", ReturnType = typeof(X509CertificateImpl))]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "GetRawCertData", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "Clone", ReturnType = typeof(X509CertificateImpl))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_Cert", ReturnType = "Mono.Security.X509.X509Certificate")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "GetRawCertData", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "EnsureCertData", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), typeof(SafePasswordHandle)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001956")]
	protected void ThrowIfContextInvalid() { }

}

