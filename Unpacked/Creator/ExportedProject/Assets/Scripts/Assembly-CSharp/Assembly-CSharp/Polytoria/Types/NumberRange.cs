namespace Polytoria.Types;

[Token(Token = "0x20002F4")]
public struct NumberRange
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B7F")]
	public float min; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B80")]
	public float max; //Field offset: 0x4

	[Address(RVA = "0x40FBC0", Offset = "0x40EDC0", Length = "0xA")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B52")]
	public NumberRange(float min, float max) { }

	[Address(RVA = "0x40FBA0", Offset = "0x40EDA0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001B53")]
	public float Lerp(float t) { }

	[Address(RVA = "0x40ED30", Offset = "0x40DF30", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B54")]
	public static NumberRange New(float min, float max) { }

}

