namespace GLTFast.Schema;

[Token(Token = "0x20000D0")]
public class SpotLight
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E7")]
	public float innerConeAngle; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002E8")]
	public float outerConeAngle; //Field offset: 0x14

	[Address(RVA = "0x107A5E0", Offset = "0x10797E0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600026C")]
	public SpotLight() { }

}

