namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000112")]
public sealed class MinAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004FB")]
	public readonly float min; //Field offset: 0x18

	[Address(RVA = "0xE66910", Offset = "0xE65B10", Length = "0x2C")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600088F")]
	public MinAttribute(float min) { }

}

