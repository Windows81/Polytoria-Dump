namespace System.Security.Cryptography;

[ComVisible(True)]
[Flags]
[Token(Token = "0x20002E5")]
public enum CspProviderFlags
{
	NoFlags = 0,
	UseMachineKeyStore = 1,
	UseDefaultKeyContainer = 2,
	UseNonExportableKey = 4,
	UseExistingKey = 8,
	UseArchivableKey = 16,
	UseUserProtectedKey = 32,
	NoPrompt = 64,
	CreateEphemeralKey = 128,
}

