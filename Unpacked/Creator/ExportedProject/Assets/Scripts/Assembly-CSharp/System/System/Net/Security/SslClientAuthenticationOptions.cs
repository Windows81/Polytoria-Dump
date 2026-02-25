namespace System.Net.Security;

[Token(Token = "0x2000310")]
public class SslClientAuthenticationOptions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E52")]
	private EncryptionPolicy _encryptionPolicy; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000E53")]
	private X509RevocationMode _checkCertificateRevocation; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E54")]
	private SslProtocols _enabledSslProtocols; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000E55")]
	private bool _allowRenegotiation; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E56")]
	private LocalCertificateSelectionCallback <LocalCertificateSelectionCallback>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E57")]
	private RemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E58")]
	private string <TargetHost>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E59")]
	private X509CertificateCollection <ClientCertificates>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x17000420")]
	public bool AllowRenegotiation
	{
		[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000425")]
	public X509RevocationMode CertificateRevocationCheckMode
	{
		[Address(RVA = "0x1729C40", Offset = "0x1728E40", Length = "0x9C")]
		[CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60013D5")]
		 set { } //Length: 156
	}

	[Token(Token = "0x17000424")]
	public X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013D3")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013D4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000427")]
	public SslProtocols EnabledSslProtocols
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013D7")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013D8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000426")]
	public EncryptionPolicy EncryptionPolicy
	{
		[Address(RVA = "0x1729CE0", Offset = "0x1728EE0", Length = "0x9C")]
		[CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60013D6")]
		 set { } //Length: 156
	}

	[Token(Token = "0x17000421")]
	public LocalCertificateSelectionCallback LocalCertificateSelectionCallback
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013CE")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013CF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000422")]
	public RemoteCertificateValidationCallback RemoteCertificateValidationCallback
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013D0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000423")]
	public string TargetHost
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013D1")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013D2")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1729C30", Offset = "0x1728E30", Length = "0xB")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013D9")]
	public SslClientAuthenticationOptions() { }

	[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013CD")]
	public bool get_AllowRenegotiation() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013D3")]
	public X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013D7")]
	public SslProtocols get_EnabledSslProtocols() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013CE")]
	public LocalCertificateSelectionCallback get_LocalCertificateSelectionCallback() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013D0")]
	public RemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013D1")]
	public string get_TargetHost() { }

	[Address(RVA = "0x1729C40", Offset = "0x1728E40", Length = "0x9C")]
	[CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013D5")]
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013D4")]
	public void set_ClientCertificates(X509CertificateCollection value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013D8")]
	public void set_EnabledSslProtocols(SslProtocols value) { }

	[Address(RVA = "0x1729CE0", Offset = "0x1728EE0", Length = "0x9C")]
	[CalledBy(Type = typeof(MonoSslClientAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013D6")]
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013CF")]
	public void set_LocalCertificateSelectionCallback(LocalCertificateSelectionCallback value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013D2")]
	public void set_TargetHost(string value) { }

}

