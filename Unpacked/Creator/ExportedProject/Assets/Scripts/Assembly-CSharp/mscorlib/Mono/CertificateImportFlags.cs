namespace Mono;

[Flags]
[Token(Token = "0x200002C")]
internal enum CertificateImportFlags
{
	None = 0,
	DisableNativeBackend = 1,
	DisableAutomaticFallback = 2,
}

