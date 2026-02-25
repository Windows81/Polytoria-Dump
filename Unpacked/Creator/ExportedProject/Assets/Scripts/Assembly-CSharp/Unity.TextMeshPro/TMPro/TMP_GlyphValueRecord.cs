namespace TMPro;

[Token(Token = "0x200005B")]
public struct TMP_GlyphValueRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400026A")]
	internal float m_XPlacement; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x400026B")]
	internal float m_YPlacement; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400026C")]
	internal float m_XAdvance; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x400026D")]
	internal float m_YAdvance; //Field offset: 0xC

	[Token(Token = "0x17000085")]
	public float xAdvance
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D0")]
		 get { } //Length: 6
		[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D1")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000083")]
	public float xPlacement
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CC")]
		 get { } //Length: 5
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CD")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000086")]
	public float yAdvance
	{
		[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D2")]
		 get { } //Length: 6
		[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D3")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000084")]
	public float yPlacement
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CE")]
		 get { } //Length: 6
		[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CF")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D4")]
	public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	[Address(RVA = "0x18A2D30", Offset = "0x18A1F30", Length = "0x17")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D5")]
	internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord) { }

	[Address(RVA = "0x189FB10", Offset = "0x189ED10", Length = "0x56")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D6")]
	internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord) { }

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D0")]
	public float get_xAdvance() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CC")]
	public float get_xPlacement() { }

	[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D2")]
	public float get_yAdvance() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CE")]
	public float get_yPlacement() { }

	[Address(RVA = "0x18A2D50", Offset = "0x18A1F50", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D7")]
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }

	[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D1")]
	public void set_xAdvance(float value) { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CD")]
	public void set_xPlacement(float value) { }

	[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D3")]
	public void set_yAdvance(float value) { }

	[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CF")]
	public void set_yPlacement(float value) { }

}

