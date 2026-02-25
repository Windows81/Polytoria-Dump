namespace Mono.Btls;

[Flags]
[Token(Token = "0x200008B")]
internal enum MonoBtlsSslRenegotiateMode
{
	NEVER = 0,
	ONCE = 1,
	FREELY = 2,
	IGNORE = 3,
}

