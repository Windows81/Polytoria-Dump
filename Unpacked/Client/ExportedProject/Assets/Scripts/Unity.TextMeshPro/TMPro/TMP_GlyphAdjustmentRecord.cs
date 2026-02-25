namespace TMPro;

[Token(Token = "0x200005C")]
public struct TMP_GlyphAdjustmentRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400026E")]
	internal uint m_GlyphIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x400026F")]
	internal TMP_GlyphValueRecord m_GlyphValueRecord; //Field offset: 0x4

	[Token(Token = "0x17000087")]
	public uint glyphIndex
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D8")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D9")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000088")]
	public TMP_GlyphValueRecord glyphValueRecord
	{
		[Address(RVA = "0xCE3930", Offset = "0xCE2B30", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DA")]
		 get { } //Length: 11
		[Address(RVA = "0x18A2AE0", Offset = "0x18A1CE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DB")]
		 set { } //Length: 8
	}

	[Address(RVA = "0xCE3310", Offset = "0xCE2510", Length = "0xB")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DC")]
	public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	[Address(RVA = "0x18A2A10", Offset = "0x18A1C10", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlyphAdjustmentRecord), Member = "get_glyphValueRecord", ReturnType = typeof(GlyphValueRecord))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60002DD")]
	internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D8")]
	public uint get_glyphIndex() { }

	[Address(RVA = "0xCE3930", Offset = "0xCE2B30", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DA")]
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D9")]
	public void set_glyphIndex(uint value) { }

	[Address(RVA = "0x18A2AE0", Offset = "0x18A1CE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DB")]
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

}

