namespace System.Net.Security;

[Token(Token = "0x2000314")]
public enum EncryptionPolicy
{
	RequireEncryption = 0,
	AllowNoEncryption = 1,
	NoEncryption = 2,
}

