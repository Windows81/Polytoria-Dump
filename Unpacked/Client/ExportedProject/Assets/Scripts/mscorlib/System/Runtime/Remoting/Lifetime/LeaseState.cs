namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
[Token(Token = "0x2000360")]
public enum LeaseState
{
	Null = 0,
	Initial = 1,
	Active = 2,
	Renewing = 3,
	Expired = 4,
}

