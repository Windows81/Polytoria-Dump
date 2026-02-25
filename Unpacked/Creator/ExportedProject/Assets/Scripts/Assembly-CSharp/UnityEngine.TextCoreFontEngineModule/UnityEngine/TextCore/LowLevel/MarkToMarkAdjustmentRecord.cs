namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000017")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct MarkToMarkAdjustmentRecord
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("baseMarkGlyphID")]
	[SerializeField]
	[Token(Token = "0x4000095")]
	private uint m_BaseMarkGlyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("baseMarkAnchor")]
	[SerializeField]
	[Token(Token = "0x4000096")]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[NativeName("combiningMarkGlyphID")]
	[SerializeField]
	[Token(Token = "0x4000097")]
	private uint m_CombiningMarkGlyphID; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("combiningMarkPositionAdjustment")]
	[SerializeField]
	[Token(Token = "0x4000098")]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; //Field offset: 0x10

	[Token(Token = "0x17000036")]
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint
	{
		[Address(RVA = "0x19DC140", Offset = "0x19DB340", Length = "0x13")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B2")]
		 get { } //Length: 19
		[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B3")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000035")]
	public uint baseMarkGlyphID
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B0")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B1")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000037")]
	public uint combiningMarkGlyphID
	{
		[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
		[CallerCount(Count = 119)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B4")]
		 get { } //Length: 6
		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000038")]
	public MarkPositionAdjustment combiningMarkPositionAdjustment
	{
		[Address(RVA = "0x19E24E0", Offset = "0x19E16E0", Length = "0x13")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B6")]
		 get { } //Length: 19
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B7")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x19DC140", Offset = "0x19DB340", Length = "0x13")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B2")]
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B0")]
	public uint get_baseMarkGlyphID() { }

	[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
	[CallerCount(Count = 119)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B4")]
	public uint get_combiningMarkGlyphID() { }

	[Address(RVA = "0x19E24E0", Offset = "0x19E16E0", Length = "0x13")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B6")]
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B3")]
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B1")]
	public void set_baseMarkGlyphID(uint value) { }

	[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B5")]
	public void set_combiningMarkGlyphID(uint value) { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B7")]
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }

}

