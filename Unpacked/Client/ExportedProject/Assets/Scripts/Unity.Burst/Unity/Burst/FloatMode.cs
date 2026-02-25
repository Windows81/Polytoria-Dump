namespace Unity.Burst;

[Token(Token = "0x2000002")]
public enum FloatMode
{
	Default = 0,
	Strict = 1,
	Deterministic = 2,
	Fast = 3,
}

