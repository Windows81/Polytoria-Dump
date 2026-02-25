namespace UnityEngine.UIElements;

[Token(Token = "0x20002EB")]
internal struct ComputedTransitionProperty
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BC1")]
	public StylePropertyId id; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000BC2")]
	public int durationMs; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BC3")]
	public int delayMs; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BC4")]
	public Func<Single, Single> easingCurve; //Field offset: 0x10

}

