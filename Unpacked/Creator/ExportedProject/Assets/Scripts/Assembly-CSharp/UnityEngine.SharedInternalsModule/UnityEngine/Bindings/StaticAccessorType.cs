namespace UnityEngine.Bindings;

[Token(Token = "0x2000016")]
[VisibleToOtherModules]
internal enum StaticAccessorType
{
	Dot = 0,
	Arrow = 1,
	DoubleColon = 2,
	ArrowWithDefaultReturnIfNull = 3,
}

