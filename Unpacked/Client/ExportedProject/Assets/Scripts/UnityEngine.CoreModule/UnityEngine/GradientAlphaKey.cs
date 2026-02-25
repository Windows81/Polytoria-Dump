namespace UnityEngine;

[Token(Token = "0x20000F7")]
[UsedByNativeCode]
public struct GradientAlphaKey
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048C")]
	public float alpha; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400048D")]
	public float time; //Field offset: 0x4

	[Address(RVA = "0x40FBC0", Offset = "0x40EDC0", Length = "0xA")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600070B")]
	public GradientAlphaKey(float alpha, float time) { }

}

