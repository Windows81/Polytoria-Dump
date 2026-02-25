namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000114")]
public sealed class TextAreaAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004FD")]
	public readonly int minLines; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004FE")]
	public readonly int maxLines; //Field offset: 0x1C

	[Address(RVA = "0x1970FF0", Offset = "0x19701F0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000891")]
	public TextAreaAttribute(int minLines, int maxLines) { }

}

