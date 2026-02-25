namespace TMPro;

[Token(Token = "0x200000B")]
public struct MarkToBaseAdjustmentRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000017")]
	private uint m_BaseGlyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000018")]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x4000019")]
	private uint m_MarkGlyphID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400001A")]
	private MarkPositionAdjustment m_MarkPositionAdjustment; //Field offset: 0x10

	[Token(Token = "0x17000006")]
	public GlyphAnchorPoint baseGlyphAnchorPoint
	{
		[Address(RVA = "0xCE3A10", Offset = "0xCE2C10", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001E")]
		 get { } //Length: 19
		[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001F")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000005")]
	public uint baseGlyphID
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001C")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001D")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000007")]
	public uint markGlyphID
	{
		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000020")]
		 get { } //Length: 4
		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000021")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public MarkPositionAdjustment markPositionAdjustment
	{
		[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000022")]
		 get { } //Length: 19
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000023")]
		 set { } //Length: 5
	}

	[Address(RVA = "0xCE3A10", Offset = "0xCE2C10", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001E")]
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	public uint get_baseGlyphID() { }

	[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000020")]
	public uint get_markGlyphID() { }

	[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000022")]
	public MarkPositionAdjustment get_markPositionAdjustment() { }

	[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001D")]
	public void set_baseGlyphID(uint value) { }

	[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000021")]
	public void set_markGlyphID(uint value) { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000023")]
	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }

}

