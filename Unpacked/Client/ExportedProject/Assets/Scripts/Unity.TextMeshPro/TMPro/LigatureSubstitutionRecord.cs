namespace TMPro;

[Token(Token = "0x2000010")]
public struct LigatureSubstitutionRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private UInt32[] m_ComponentGlyphIDs; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000022")]
	private uint m_LigatureGlyphID; //Field offset: 0x8

	[Token(Token = "0x1700000F")]
	public UInt32[] componentGlyphIDs
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000030")]
		 get { } //Length: 4
		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000031")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000010")]
	public uint ligatureGlyphID
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000032")]
		 get { } //Length: 4
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000033")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000030")]
	public UInt32[] get_componentGlyphIDs() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	public uint get_ligatureGlyphID() { }

	[Address(RVA = "0x18732D0", Offset = "0x18724D0", Length = "0x7D")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000034")]
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	[Address(RVA = "0x1873350", Offset = "0x1872550", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000035")]
	public static bool op_Inequality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000031")]
	public void set_componentGlyphIDs(UInt32[] value) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	public void set_ligatureGlyphID(uint value) { }

}

