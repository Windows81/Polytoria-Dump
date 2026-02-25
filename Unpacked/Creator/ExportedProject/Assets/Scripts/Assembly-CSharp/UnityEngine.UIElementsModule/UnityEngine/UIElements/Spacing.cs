namespace UnityEngine.UIElements;

[Token(Token = "0x20002DD")]
internal struct Spacing
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B96")]
	public float left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B97")]
	public float top; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B98")]
	public float right; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000B99")]
	public float bottom; //Field offset: 0xC

	[Token(Token = "0x170003D8")]
	public float horizontal
	{
		[Address(RVA = "0x193C360", Offset = "0x193B560", Length = "0xC")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001400")]
		 get { } //Length: 12
	}

	[Token(Token = "0x170003D9")]
	public float vertical
	{
		[Address(RVA = "0x193C370", Offset = "0x193B570", Length = "0xD")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001401")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001402")]
	public Spacing(float left, float top, float right, float bottom) { }

	[Address(RVA = "0x193C360", Offset = "0x193B560", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001400")]
	public float get_horizontal() { }

	[Address(RVA = "0x193C370", Offset = "0x193B570", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001401")]
	public float get_vertical() { }

	[Address(RVA = "0x1AE9DB0", Offset = "0x1AE8FB0", Length = "0x70")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_paddingRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6001403")]
	public static Rect op_Subtraction(Rect r, Spacing a) { }

}

