namespace UnityEngine;

[Flags]
[Token(Token = "0x2000007")]
public enum AdditionalCanvasShaderChannels
{
	None = 0,
	TexCoord1 = 1,
	TexCoord2 = 2,
	TexCoord3 = 4,
	Normal = 8,
	Tangent = 16,
}

