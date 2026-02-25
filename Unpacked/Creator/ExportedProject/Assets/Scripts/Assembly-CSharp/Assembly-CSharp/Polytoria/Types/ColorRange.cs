namespace Polytoria.Types;

[Token(Token = "0x20002F0")]
public struct ColorRange
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B78")]
	public Color min; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B79")]
	public Color max; //Field offset: 0x10

	[Address(RVA = "0x407130", Offset = "0x406330", Length = "0xF")]
	[CalledBy(Type = typeof(Particles), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridItemColorRange), Member = "OnValueChangeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyGridItemColorRange), Member = "OnValueChangeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameIO), Member = "XmlConvertColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(ColorRange))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6001B4C")]
	public ColorRange(Color min, Color max) { }

	[Address(RVA = "0x407050", Offset = "0x406250", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B4D")]
	public Color Lerp(float t) { }

	[Address(RVA = "0x407110", Offset = "0x406310", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B4E")]
	public static ColorRange New(Color min, Color max) { }

}

