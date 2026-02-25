namespace Mono.Net.Security;

[Token(Token = "0x2000060")]
internal sealed class MonoSslServerAuthenticationOptions : MonoSslAuthenticationOptions
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000113")]
	private readonly SslServerAuthenticationOptions <Options>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000055")]
	public virtual bool AllowRenegotiation
	{
		[Address(RVA = "0x15FAB40", Offset = "0x15F9D40", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000164")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000056")]
	public virtual X509RevocationMode CertificateRevocationCheckMode
	{
		[Address(RVA = "0x15FAE30", Offset = "0x15FA030", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SslServerAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000165")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000059")]
	public virtual bool ClientCertificateRequired
	{
		[Address(RVA = "0x15FAD90", Offset = "0x15F9F90", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000169")]
		 get { } //Length: 27
		[Address(RVA = "0x15FAE50", Offset = "0x15FA050", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600016A")]
		 set { } //Length: 26
	}

	[Token(Token = "0x1700005C")]
	public virtual X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x15FADB0", Offset = "0x15F9FB0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600016F")]
		 get { } //Length: 62
		[Address(RVA = "0x15FAE70", Offset = "0x15FA070", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000170")]
		 set { } //Length: 62
	}

	[Token(Token = "0x17000058")]
	public virtual SslProtocols EnabledSslProtocols
	{
		[Address(RVA = "0x3BD080", Offset = "0x3BC280", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000167")]
		 get { } //Length: 26
		[Address(RVA = "0x15FAEB0", Offset = "0x15FA0B0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000168")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000057")]
	public virtual EncryptionPolicy EncryptionPolicy
	{
		[Address(RVA = "0x15FAED0", Offset = "0x15FA0D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SslServerAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000166")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000053")]
	public SslServerAuthenticationOptions Options
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000161")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005B")]
	public virtual X509Certificate ServerCertificate
	{
		[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600016D")]
		 get { } //Length: 27
		[Address(RVA = "0x15FAEF0", Offset = "0x15FA0F0", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600016E")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000054")]
	public virtual bool ServerMode
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000162")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700005A")]
	public virtual string TargetHost
	{
		[Address(RVA = "0x15FADF0", Offset = "0x15F9FF0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600016B")]
		 get { } //Length: 62
		[Address(RVA = "0x15FAF20", Offset = "0x15FA120", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600016C")]
		 set { } //Length: 62
	}

	[Address(RVA = "0x15FAD20", Offset = "0x15F9F20", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000163")]
	public MonoSslServerAuthenticationOptions() { }

	[Address(RVA = "0x15FAB40", Offset = "0x15F9D40", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000164")]
	public virtual bool get_AllowRenegotiation() { }

	[Address(RVA = "0x15FAD90", Offset = "0x15F9F90", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000169")]
	public virtual bool get_ClientCertificateRequired() { }

	[Address(RVA = "0x15FADB0", Offset = "0x15F9FB0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600016F")]
	public virtual X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0x3BD080", Offset = "0x3BC280", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000167")]
	public virtual SslProtocols get_EnabledSslProtocols() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000161")]
	public SslServerAuthenticationOptions get_Options() { }

	[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600016D")]
	public virtual X509Certificate get_ServerCertificate() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000162")]
	public virtual bool get_ServerMode() { }

	[Address(RVA = "0x15FADF0", Offset = "0x15F9FF0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600016B")]
	public virtual string get_TargetHost() { }

	[Address(RVA = "0x15FAE30", Offset = "0x15FA030", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SslServerAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000165")]
	public virtual void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[Address(RVA = "0x15FAE50", Offset = "0x15FA050", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016A")]
	public virtual void set_ClientCertificateRequired(bool value) { }

	[Address(RVA = "0x15FAE70", Offset = "0x15FA070", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000170")]
	public virtual void set_ClientCertificates(X509CertificateCollection value) { }

	[Address(RVA = "0x15FAEB0", Offset = "0x15FA0B0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000168")]
	public virtual void set_EnabledSslProtocols(SslProtocols value) { }

	[Address(RVA = "0x15FAED0", Offset = "0x15FA0D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SslServerAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionPolicy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000166")]
	public virtual void set_EncryptionPolicy(EncryptionPolicy value) { }

	[Address(RVA = "0x15FAEF0", Offset = "0x15FA0F0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016E")]
	public virtual void set_ServerCertificate(X509Certificate value) { }

	[Address(RVA = "0x15FAF20", Offset = "0x15FA120", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600016C")]
	public virtual void set_TargetHost(string value) { }

}

