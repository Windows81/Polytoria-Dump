namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200012B")]
internal abstract class X509Certificate2Impl : X509CertificateImpl
{

	[Token(Token = "0x1700012A")]
	public abstract IEnumerable<X509Extension> Extensions
	{
		[Token(Token = "0x6000708")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000130")]
	internal abstract X509CertificateImplCollection IntermediateCertificates
	{
		[Token(Token = "0x600070F")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x1700012B")]
	public abstract X500DistinguishedName IssuerName
	{
		[Token(Token = "0x6000709")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700012C")]
	public abstract AsymmetricAlgorithm PrivateKey
	{
		[Token(Token = "0x600070A")]
		 get { } //Length: 0
		[Token(Token = "0x600070B")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700012D")]
	public abstract string SignatureAlgorithm
	{
		[Token(Token = "0x600070C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700012E")]
	public abstract X500DistinguishedName SubjectName
	{
		[Token(Token = "0x600070D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700012F")]
	public abstract int Version
	{
		[Token(Token = "0x600070E")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000713")]
	protected X509Certificate2Impl() { }

	[Token(Token = "0x6000712")]
	public abstract void AppendPrivateKeyInfo(StringBuilder sb) { }

	[Token(Token = "0x6000708")]
	public abstract IEnumerable<X509Extension> get_Extensions() { }

	[Token(Token = "0x600070F")]
	internal abstract X509CertificateImplCollection get_IntermediateCertificates() { }

	[Token(Token = "0x6000709")]
	public abstract X500DistinguishedName get_IssuerName() { }

	[Token(Token = "0x600070A")]
	public abstract AsymmetricAlgorithm get_PrivateKey() { }

	[Token(Token = "0x600070C")]
	public abstract string get_SignatureAlgorithm() { }

	[Token(Token = "0x600070D")]
	public abstract X500DistinguishedName get_SubjectName() { }

	[Token(Token = "0x600070E")]
	public abstract int get_Version() { }

	[Token(Token = "0x6000710")]
	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[Token(Token = "0x600070B")]
	public abstract void set_PrivateKey(AsymmetricAlgorithm value) { }

	[Token(Token = "0x6000711")]
	public abstract bool Verify(X509Certificate2 thisCertificate) { }

}

