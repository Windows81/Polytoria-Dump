namespace TMPro;

[Token(Token = "0x2000021")]
public struct VertexGradient
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C4")]
	public Color topLeft; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C5")]
	public Color topRight; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C6")]
	public Color bottomLeft; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000C7")]
	public Color bottomRight; //Field offset: 0x30

	[Address(RVA = "0x189F9A0", Offset = "0x189EBA0", Length = "0x13")]
	[CalledBy(Type = typeof(TMP_Text), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600013C")]
	public VertexGradient(Color color) { }

	[Address(RVA = "0x189F970", Offset = "0x189EB70", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600013D")]
	public VertexGradient(Color color0, Color color1, Color color2, Color color3) { }

}

