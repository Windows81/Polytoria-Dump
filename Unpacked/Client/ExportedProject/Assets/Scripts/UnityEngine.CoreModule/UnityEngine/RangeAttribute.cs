namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000111")]
public sealed class RangeAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F9")]
	public readonly float min; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004FA")]
	public readonly float max; //Field offset: 0x1C

	[Address(RVA = "0x196BDD0", Offset = "0x196AFD0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600088E")]
	public RangeAttribute(float min, float max) { }

}

