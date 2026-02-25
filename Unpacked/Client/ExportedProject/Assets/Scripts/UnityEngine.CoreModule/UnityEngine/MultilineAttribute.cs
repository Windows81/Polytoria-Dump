namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000113")]
public sealed class MultilineAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004FC")]
	public readonly int lines; //Field offset: 0x18

	[Address(RVA = "0x1965F70", Offset = "0x1965170", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000890")]
	public MultilineAttribute() { }

}

