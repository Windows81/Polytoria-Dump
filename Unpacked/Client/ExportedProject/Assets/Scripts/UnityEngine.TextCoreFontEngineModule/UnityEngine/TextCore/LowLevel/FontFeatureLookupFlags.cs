namespace UnityEngine.TextCore.LowLevel;

[Flags]
[Token(Token = "0x2000010")]
public enum FontFeatureLookupFlags
{
	None = 0,
	IgnoreLigatures = 4,
	IgnoreSpacingAdjustments = 256,
}

