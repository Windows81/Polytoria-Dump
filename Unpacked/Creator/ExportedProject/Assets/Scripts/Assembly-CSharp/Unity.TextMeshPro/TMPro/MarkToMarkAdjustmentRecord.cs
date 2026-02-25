namespace TMPro;

[Token(Token = "0x200000C")]
public struct MarkToMarkAdjustmentRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400001B")]
	private uint m_BaseMarkGlyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	private uint m_CombiningMarkGlyphID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; //Field offset: 0x10

	[Token(Token = "0x1700000A")]
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint
	{
		[Address(RVA = "0xCE3A10", Offset = "0xCE2C10", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000026")]
		 get { } //Length: 19
		[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000027")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	public uint baseMarkGlyphID
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000024")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000025")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700000B")]
	public uint combiningMarkGlyphID
	{
		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000028")]
		 get { } //Length: 4
		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000029")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000C")]
	public MarkPositionAdjustment combiningMarkPositionAdjustment
	{
		[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002A")]
		 get { } //Length: 19
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002B")]
		 set { } //Length: 5
	}

	[Address(RVA = "0xCE3A10", Offset = "0xCE2C10", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000026")]
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000024")]
	public uint get_baseMarkGlyphID() { }

	[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000028")]
	public uint get_combiningMarkGlyphID() { }

	[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002A")]
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000027")]
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000025")]
	public void set_baseMarkGlyphID(uint value) { }

	[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000029")]
	public void set_combiningMarkGlyphID(uint value) { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002B")]
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }

}

