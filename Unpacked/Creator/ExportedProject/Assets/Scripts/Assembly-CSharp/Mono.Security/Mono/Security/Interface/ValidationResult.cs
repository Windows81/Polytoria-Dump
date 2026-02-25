namespace Mono.Security.Interface;

[Token(Token = "0x200003B")]
public class ValidationResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D1")]
	private bool trusted; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40000D2")]
	private bool user_denied; //Field offset: 0x11
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D3")]
	private int error_code; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D4")]
	private Nullable<MonoSslPolicyErrors> policy_errors; //Field offset: 0x18

	[Token(Token = "0x17000060")]
	public bool Trusted
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000145")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000061")]
	public bool UserDenied
	{
		[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000146")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x12D52B0", Offset = "0x12D44B0", Length = "0x50")]
	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain&), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000144")]
	public ValidationResult(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000145")]
	public bool get_Trusted() { }

	[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000146")]
	public bool get_UserDenied() { }

}

