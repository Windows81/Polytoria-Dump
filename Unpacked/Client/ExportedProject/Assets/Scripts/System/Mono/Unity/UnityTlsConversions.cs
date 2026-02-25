namespace Mono.Unity;

[Token(Token = "0x2000042")]
internal static class UnityTlsConversions
{

	[Address(RVA = "0x1603FD0", Offset = "0x16031D0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000090")]
	public static TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	[Address(RVA = "0x1604000", Offset = "0x1603200", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600008F")]
	public static unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	[Address(RVA = "0x1604040", Offset = "0x1603240", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600008E")]
	public static unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	[Address(RVA = "0x1604080", Offset = "0x1603280", Length = "0x5C")]
	[CalledBy(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_errorstate), typeof(unitytls_x509verify_result), typeof(string), typeof(AlertDescription)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000091")]
	public static AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	[Address(RVA = "0x16040E0", Offset = "0x16032E0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000093")]
	public static X509ChainStatusFlags VerifyResultToChainStatus(unitytls_x509verify_result verifyResult) { }

	[Address(RVA = "0x1604120", Offset = "0x1603320", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000092")]
	public static SslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

}

