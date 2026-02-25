namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000019")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule", "UnityEditor.TextCoreTextEngineModule"})]
internal struct LigatureSubstitutionRecord : IEquatable<LigatureSubstitutionRecord>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("componentGlyphs")]
	[SerializeField]
	[Token(Token = "0x400009B")]
	private UInt32[] m_ComponentGlyphIDs; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("ligatureGlyph")]
	[SerializeField]
	[Token(Token = "0x400009C")]
	private uint m_LigatureGlyphID; //Field offset: 0x8

	[Token(Token = "0x17000039")]
	public UInt32[] componentGlyphIDs
	{
		[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
		[CallerCount(Count = 95)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B8")]
		 get { } //Length: 6
		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B9")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700003A")]
	public uint ligatureGlyphID
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BA")]
		 get { } //Length: 6
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BB")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1A23950", Offset = "0x1A22B50", Length = "0xB0")]
	[CalledBy(Type = typeof(LigatureSubstitutionRecord), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000BC")]
	public override bool Equals(LigatureSubstitutionRecord other) { }

	[Address(RVA = "0x1A23A10", Offset = "0x1A22C10", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(LigatureSubstitutionRecord), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60000BD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B8")]
	public UInt32[] get_componentGlyphIDs() { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BA")]
	public uint get_ligatureGlyphID() { }

	[Address(RVA = "0x1A23AB0", Offset = "0x1A22CB0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A23AE0", Offset = "0x1A22CE0", Length = "0x93")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000BF")]
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B9")]
	public void set_componentGlyphIDs(UInt32[] value) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BB")]
	public void set_ligatureGlyphID(uint value) { }

}

