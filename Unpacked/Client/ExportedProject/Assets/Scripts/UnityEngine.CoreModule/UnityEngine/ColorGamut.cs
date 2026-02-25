namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[Token(Token = "0x20000CE")]
[UsedByNativeCode]
public enum ColorGamut
{
	sRGB = 0,
	Rec709 = 1,
	Rec2020 = 2,
	DisplayP3 = 3,
	HDR10 = 4,
	DolbyHDR = 5,
	P3D65G22 = 6,
}

