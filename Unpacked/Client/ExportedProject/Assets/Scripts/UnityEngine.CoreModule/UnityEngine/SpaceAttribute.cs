namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = True)]
[Token(Token = "0x200010F")]
public class SpaceAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F7")]
	public readonly float height; //Field offset: 0x18

	[Address(RVA = "0x196F310", Offset = "0x196E510", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600088B")]
	public SpaceAttribute() { }

	[Address(RVA = "0x196F2E0", Offset = "0x196E4E0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600088C")]
	public SpaceAttribute(float height) { }

}

