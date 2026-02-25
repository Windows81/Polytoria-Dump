namespace TMPro;

[Token(Token = "0x200000E")]
public struct MultipleSubstitutionRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400001F")]
	private uint m_TargetGlyphID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000020")]
	private UInt32[] m_SubstituteGlyphIDs; //Field offset: 0x8

	[Token(Token = "0x1700000E")]
	public UInt32[] substituteGlyphIDs
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		 get { } //Length: 5
		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000D")]
	public uint targetGlyphID
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002C")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public UInt32[] get_substituteGlyphIDs() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002C")]
	public uint get_targetGlyphID() { }

	[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	public void set_substituteGlyphIDs(UInt32[] value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public void set_targetGlyphID(uint value) { }

}

