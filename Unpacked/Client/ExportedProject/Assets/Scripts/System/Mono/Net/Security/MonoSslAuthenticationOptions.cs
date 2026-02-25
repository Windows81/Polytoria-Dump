namespace Mono.Net.Security;

[Token(Token = "0x200005E")]
internal abstract class MonoSslAuthenticationOptions
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000111")]
	private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000040")]
	public abstract bool AllowRenegotiation
	{
		[Token(Token = "0x6000142")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000043")]
	public abstract X509RevocationMode CertificateRevocationCheckMode
	{
		[Token(Token = "0x6000146")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000047")]
	public abstract bool ClientCertificateRequired
	{
		[Token(Token = "0x600014D")]
		 get { } //Length: 0
		[Token(Token = "0x600014E")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000046")]
	public abstract X509CertificateCollection ClientCertificates
	{
		[Token(Token = "0x600014B")]
		 get { } //Length: 0
		[Token(Token = "0x600014C")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000041")]
	public abstract SslProtocols EnabledSslProtocols
	{
		[Token(Token = "0x6000143")]
		 get { } //Length: 0
		[Token(Token = "0x6000144")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000042")]
	public abstract EncryptionPolicy EncryptionPolicy
	{
		[Token(Token = "0x6000145")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000045")]
	public abstract X509Certificate ServerCertificate
	{
		[Token(Token = "0x6000149")]
		 get { } //Length: 0
		[Token(Token = "0x600014A")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000048")]
	internal ServerCertSelectionCallback ServerCertSelectionDelegate
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600014F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700003F")]
	public abstract bool ServerMode
	{
		[Token(Token = "0x6000141")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000044")]
	public abstract string TargetHost
	{
		[Token(Token = "0x6000147")]
		 get { } //Length: 0
		[Token(Token = "0x6000148")]
		 set { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000150")]
	protected MonoSslAuthenticationOptions() { }

	[Token(Token = "0x6000142")]
	public abstract bool get_AllowRenegotiation() { }

	[Token(Token = "0x600014D")]
	public abstract bool get_ClientCertificateRequired() { }

	[Token(Token = "0x600014B")]
	public abstract X509CertificateCollection get_ClientCertificates() { }

	[Token(Token = "0x6000143")]
	public abstract SslProtocols get_EnabledSslProtocols() { }

	[Token(Token = "0x6000149")]
	public abstract X509Certificate get_ServerCertificate() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600014F")]
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	[Token(Token = "0x6000141")]
	public abstract bool get_ServerMode() { }

	[Token(Token = "0x6000147")]
	public abstract string get_TargetHost() { }

	[Token(Token = "0x6000146")]
	public abstract void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[Token(Token = "0x600014E")]
	public abstract void set_ClientCertificateRequired(bool value) { }

	[Token(Token = "0x600014C")]
	public abstract void set_ClientCertificates(X509CertificateCollection value) { }

	[Token(Token = "0x6000144")]
	public abstract void set_EnabledSslProtocols(SslProtocols value) { }

	[Token(Token = "0x6000145")]
	public abstract void set_EncryptionPolicy(EncryptionPolicy value) { }

	[Token(Token = "0x600014A")]
	public abstract void set_ServerCertificate(X509Certificate value) { }

	[Token(Token = "0x6000148")]
	public abstract void set_TargetHost(string value) { }

}

