namespace Mono.Net.Security;

[Token(Token = "0x200005F")]
internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000112")]
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700004B")]
	public virtual bool AllowRenegotiation
	{
		[Address(RVA = "0x15FAB40", Offset = "0x15F9D40", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000154")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700004C")]
	public virtual X509RevocationMode CertificateRevocationCheckMode
	{
		[Address(RVA = "0x15FABE0", Offset = "0x15F9DE0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SslClientAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000155")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000050")]
	public virtual bool ClientCertificateRequired
	{
		[Address(RVA = "0x15FAB60", Offset = "0x15F9D60", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600015B")]
		 get { } //Length: 62
		[Address(RVA = "0x15FAC00", Offset = "0x15F9E00", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600015C")]
		 set { } //Length: 62
	}

	[Token(Token = "0x17000051")]
	public virtual X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x3B6AF0", Offset = "0x3B5CF0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600015D")]
		 get { } //Length: 27
		[Address(RVA = "0x15FAC40", Offset = "0x15F9E40", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600015E")]
		 set { } //Length: 35
	}

	[Token(Token = "0x1700004E")]
	public virtual SslProtocols EnabledSslProtocols
	{
		[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000157")]
		 get { } //Length: 26
		[Address(RVA = "0x15FAC70", Offset = "0x15F9E70", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000158")]
		 set { } //Length: 26
	}

	[Token(Token = "0x1700004D")]
	public virtual EncryptionPolicy EncryptionPolicy
	{
		[Address(RVA = "0x15FAC90", Offset = "0x15F9E90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SslClientAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000156")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000049")]
	public SslClientAuthenticationOptions Options
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000151")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000052")]
	public virtual X509Certificate ServerCertificate
	{
		[Address(RVA = "0x15FABA0", Offset = "0x15F9DA0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600015F")]
		 get { } //Length: 62
		[Address(RVA = "0x15FACB0", Offset = "0x15F9EB0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000160")]
		 set { } //Length: 62
	}

	[Token(Token = "0x1700004A")]
	public virtual bool ServerMode
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000152")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700004F")]
	public virtual string TargetHost
	{
		[Address(RVA = "0x3B6AB0", Offset = "0x3B5CB0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000159")]
		 get { } //Length: 27
		[Address(RVA = "0x15FACF0", Offset = "0x15F9EF0", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600015A")]
		 set { } //Length: 35
	}

	[Address(RVA = "0x15FAAD0", Offset = "0x15F9CD0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000153")]
	public MonoSslClientAuthenticationOptions() { }

	[Address(RVA = "0x15FAB40", Offset = "0x15F9D40", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000154")]
	public virtual bool get_AllowRenegotiation() { }

	[Address(RVA = "0x15FAB60", Offset = "0x15F9D60", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600015B")]
	public virtual bool get_ClientCertificateRequired() { }

	[Address(RVA = "0x3B6AF0", Offset = "0x3B5CF0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600015D")]
	public virtual X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000157")]
	public virtual SslProtocols get_EnabledSslProtocols() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000151")]
	public SslClientAuthenticationOptions get_Options() { }

	[Address(RVA = "0x15FABA0", Offset = "0x15F9DA0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600015F")]
	public virtual X509Certificate get_ServerCertificate() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000152")]
	public virtual bool get_ServerMode() { }

	[Address(RVA = "0x3B6AB0", Offset = "0x3B5CB0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000159")]
	public virtual string get_TargetHost() { }

	[Address(RVA = "0x15FABE0", Offset = "0x15F9DE0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SslClientAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000155")]
	public virtual void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[Address(RVA = "0x15FAC00", Offset = "0x15F9E00", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600015C")]
	public virtual void set_ClientCertificateRequired(bool value) { }

	[Address(RVA = "0x15FAC40", Offset = "0x15F9E40", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600015E")]
	public virtual void set_ClientCertificates(X509CertificateCollection value) { }

	[Address(RVA = "0x15FAC70", Offset = "0x15F9E70", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000158")]
	public virtual void set_EnabledSslProtocols(SslProtocols value) { }

	[Address(RVA = "0x15FAC90", Offset = "0x15F9E90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SslClientAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000156")]
	public virtual void set_EncryptionPolicy(EncryptionPolicy value) { }

	[Address(RVA = "0x15FACB0", Offset = "0x15F9EB0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000160")]
	public virtual void set_ServerCertificate(X509Certificate value) { }

	[Address(RVA = "0x15FACF0", Offset = "0x15F9EF0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600015A")]
	public virtual void set_TargetHost(string value) { }

}

