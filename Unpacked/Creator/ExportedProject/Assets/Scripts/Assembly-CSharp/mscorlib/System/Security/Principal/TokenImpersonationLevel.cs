namespace System.Security.Principal;

[Token(Token = "0x200032B")]
public enum TokenImpersonationLevel
{
	None = 0,
	Anonymous = 1,
	Identification = 2,
	Impersonation = 3,
	Delegation = 4,
}

