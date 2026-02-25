namespace System.Net.Sockets;

[Token(Token = "0x20002EF")]
public enum IPProtectionLevel
{
	Unspecified = -1,
	Unrestricted = 10,
	EdgeRestricted = 20,
	Restricted = 30,
}

