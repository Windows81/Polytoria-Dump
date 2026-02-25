namespace TMPro;

[Token(Token = "0x200005D")]
public class TMP_GlyphPairAdjustmentRecord
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000270")]
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; //Field offset: 0x10
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000271")]
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; //Field offset: 0x24
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000272")]
	internal FontFeatureLookupFlags m_FeatureLookupFlags; //Field offset: 0x38

	[Token(Token = "0x1700008B")]
	public FontFeatureLookupFlags featureLookupFlags
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E2")]
		 get { } //Length: 4
		[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000089")]
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord
	{
		[Address(RVA = "0xB2E340", Offset = "0xB2D540", Length = "0x11")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DE")]
		 get { } //Length: 17
		[Address(RVA = "0x18A2D10", Offset = "0x18A1F10", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002DF")]
		 set { } //Length: 14
	}

	[Token(Token = "0x1700008A")]
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord
	{
		[Address(RVA = "0x18A2CF0", Offset = "0x18A1EF0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 17
		[Address(RVA = "0x18A2D20", Offset = "0x18A1F20", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E1")]
		 set { } //Length: 14
	}

	[Address(RVA = "0x18A2AF0", Offset = "0x18A1CF0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002E4")]
	public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	[Address(RVA = "0x18A2B40", Offset = "0x18A1D40", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(GlyphAdjustmentRecord), Member = "get_glyphValueRecord", ReturnType = typeof(GlyphValueRecord))]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x60002E5")]
	internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E2")]
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	[Address(RVA = "0xB2E340", Offset = "0xB2D540", Length = "0x11")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DE")]
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	[Address(RVA = "0x18A2CF0", Offset = "0x18A1EF0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E0")]
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E3")]
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	[Address(RVA = "0x18A2D10", Offset = "0x18A1F10", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002DF")]
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	[Address(RVA = "0x18A2D20", Offset = "0x18A1F20", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E1")]
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

}

