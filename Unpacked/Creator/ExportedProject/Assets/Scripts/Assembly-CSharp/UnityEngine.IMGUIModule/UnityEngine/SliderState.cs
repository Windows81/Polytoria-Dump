namespace UnityEngine;

[Token(Token = "0x200002C")]
internal class SliderState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000110")]
	public float dragStartPos; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000111")]
	public float dragStartValue; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000112")]
	public bool isDragging; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000274")]
	public SliderState() { }

}

