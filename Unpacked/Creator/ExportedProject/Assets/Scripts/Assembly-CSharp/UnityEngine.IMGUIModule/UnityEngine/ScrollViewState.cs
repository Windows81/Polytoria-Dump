namespace UnityEngine;

[Token(Token = "0x200002B")]
internal class ScrollViewState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000106")]
	public Rect position; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000107")]
	public Rect visibleRect; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000108")]
	public Rect viewRect; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000109")]
	public Vector2 scrollPosition; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400010A")]
	public bool apply; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x400010B")]
	public bool isDuringTouchScroll; //Field offset: 0x49
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400010C")]
	public Vector2 touchScrollStartMousePosition; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400010D")]
	public Vector2 touchScrollStartPosition; //Field offset: 0x54
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400010E")]
	public Vector2 velocity; //Field offset: 0x5C
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400010F")]
	public float previousTimeSinceStartup; //Field offset: 0x64

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000273")]
	public ScrollViewState() { }

}

