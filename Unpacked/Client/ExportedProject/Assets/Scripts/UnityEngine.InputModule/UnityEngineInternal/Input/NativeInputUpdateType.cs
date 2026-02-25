namespace UnityEngineInternal.Input;

[Flags]
[Token(Token = "0x2000004")]
internal enum NativeInputUpdateType
{
	Dynamic = 1,
	Fixed = 2,
	BeforeRender = 4,
	Editor = 8,
	IgnoreFocus = -2147483648,
}

