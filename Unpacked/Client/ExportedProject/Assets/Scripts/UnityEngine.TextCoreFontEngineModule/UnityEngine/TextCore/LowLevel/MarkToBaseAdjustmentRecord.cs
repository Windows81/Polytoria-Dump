namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000016")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct MarkToBaseAdjustmentRecord
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("baseGlyphID")]
	[SerializeField]
	[Token(Token = "0x4000091")]
	private uint m_BaseGlyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("baseAnchor")]
	[SerializeField]
	[Token(Token = "0x4000092")]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[NativeName("markGlyphID")]
	[SerializeField]
	[Token(Token = "0x4000093")]
	private uint m_MarkGlyphID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("markPositionAdjustment")]
	[SerializeField]
	[Token(Token = "0x4000094")]
	private MarkPositionAdjustment m_MarkPositionAdjustment; //Field offset: 0x10

	[Token(Token = "0x17000032")]
	public GlyphAnchorPoint baseGlyphAnchorPoint
	{
		[Address(RVA = "0x19DC140", Offset = "0x19DB340", Length = "0x13")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AA")]
		 get { } //Length: 19
		[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AB")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000031")]
	public uint baseGlyphID
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A8")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A9")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000033")]
	public uint markGlyphID
	{
		[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
		[CallerCount(Count = 119)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AC")]
		 get { } //Length: 6
		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000034")]
	public MarkPositionAdjustment markPositionAdjustment
	{
		[Address(RVA = "0x19E24E0", Offset = "0x19E16E0", Length = "0x13")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AE")]
		 get { } //Length: 19
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AF")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x19DC140", Offset = "0x19DB340", Length = "0x13")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AA")]
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A8")]
	public uint get_baseGlyphID() { }

	[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
	[CallerCount(Count = 119)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AC")]
	public uint get_markGlyphID() { }

	[Address(RVA = "0x19E24E0", Offset = "0x19E16E0", Length = "0x13")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AE")]
	public MarkPositionAdjustment get_markPositionAdjustment() { }

	[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AB")]
	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A9")]
	public void set_baseGlyphID(uint value) { }

	[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AD")]
	public void set_markGlyphID(uint value) { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AF")]
	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }

}

