namespace System.Net.Security;

[Token(Token = "0x2000311")]
public class SslServerAuthenticationOptions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E5A")]
	private X509RevocationMode _checkCertificateRevocation; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000E5B")]
	private SslProtocols _enabledSslProtocols; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E5C")]
	private EncryptionPolicy _encryptionPolicy; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000E5D")]
	private bool _allowRenegotiation; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x4000E5E")]
	private bool <ClientCertificateRequired>k__BackingField; //Field offset: 0x1D
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E5F")]
	private X509Certificate <ServerCertificate>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000428")]
	public bool AllowRenegotiation
	{
		[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700042C")]
	public X509RevocationMode CertificateRevocationCheckMode
	{
		[Address(RVA = "0x1729D80", Offset = "0x1728F80", Length = "0x9C")]
		[CalledBy(Type = typeof(MonoSslServerAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60013E1")]
		 set { } //Length: 156
	}

	[Token(Token = "0x17000429")]
	public bool ClientCertificateRequired
	{
		[Address(RVA = "0x2F6C10", Offset = "0x2F5E10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DB")]
		 get { } //Length: 5
		[Address(RVA = "0x2F6CD0", Offset = "0x2F5ED0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700042B")]
	public SslProtocols EnabledSslProtocols
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DF")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013E0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700042D")]
	public EncryptionPolicy EncryptionPolicy
	{
		[Address(RVA = "0x1729E20", Offset = "0x1729020", Length = "0x9C")]
		[CalledBy(Type = typeof(MonoSslServerAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60013E2")]
		 set { } //Length: 156
	}

	[Token(Token = "0x1700042A")]
	public X509Certificate ServerCertificate
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DD")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DE")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1729C30", Offset = "0x1728E30", Length = "0xB")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013E3")]
	public SslServerAuthenticationOptions() { }

	[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DA")]
	public bool get_AllowRenegotiation() { }

	[Address(RVA = "0x2F6C10", Offset = "0x2F5E10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DB")]
	public bool get_ClientCertificateRequired() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DF")]
	public SslProtocols get_EnabledSslProtocols() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DD")]
	public X509Certificate get_ServerCertificate() { }

	[Address(RVA = "0x1729D80", Offset = "0x1728F80", Length = "0x9C")]
	[CalledBy(Type = typeof(MonoSslServerAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013E1")]
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[Address(RVA = "0x2F6CD0", Offset = "0x2F5ED0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DC")]
	public void set_ClientCertificateRequired(bool value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013E0")]
	public void set_EnabledSslProtocols(SslProtocols value) { }

	[Address(RVA = "0x1729E20", Offset = "0x1729020", Length = "0x9C")]
	[CalledBy(Type = typeof(MonoSslServerAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013E2")]
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DE")]
	public void set_ServerCertificate(X509Certificate value) { }

}

