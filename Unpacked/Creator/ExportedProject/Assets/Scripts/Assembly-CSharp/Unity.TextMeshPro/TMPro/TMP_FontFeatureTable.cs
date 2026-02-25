namespace TMPro;

[Token(Token = "0x200005F")]
public class TMP_FontFeatureTable
{
	[CompilerGenerated]
	[Token(Token = "0x2000060")]
	private sealed class <>c
	{
		[Token(Token = "0x400027F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000280")]
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__25_0; //Field offset: 0x8
		[Token(Token = "0x4000281")]
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__25_1; //Field offset: 0x10
		[Token(Token = "0x4000282")]
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__26_0; //Field offset: 0x18
		[Token(Token = "0x4000283")]
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__26_1; //Field offset: 0x20
		[Token(Token = "0x4000284")]
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__27_0; //Field offset: 0x28
		[Token(Token = "0x4000285")]
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__27_1; //Field offset: 0x30

		[Address(RVA = "0x18B3BA0", Offset = "0x18B2DA0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002F6")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F7")]
		public <>c() { }

		[Address(RVA = "0x18B39D0", Offset = "0x18B2BD0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F8")]
		internal uint <SortGlyphPairAdjustmentRecords>b__25_0(GlyphPairAdjustmentRecord s) { }

		[Address(RVA = "0x18B3A10", Offset = "0x18B2C10", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F9")]
		internal uint <SortGlyphPairAdjustmentRecords>b__25_1(GlyphPairAdjustmentRecord s) { }

		[Address(RVA = "0x418BB0", Offset = "0x417DB0", Length = "0x3")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FA")]
		internal uint <SortMarkToBaseAdjustmentRecords>b__26_0(MarkToBaseAdjustmentRecord s) { }

		[Address(RVA = "0x18B3AB0", Offset = "0x18B2CB0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FB")]
		internal uint <SortMarkToBaseAdjustmentRecords>b__26_1(MarkToBaseAdjustmentRecord s) { }

		[Address(RVA = "0x418BB0", Offset = "0x417DB0", Length = "0x3")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FC")]
		internal uint <SortMarkToMarkAdjustmentRecords>b__27_0(MarkToMarkAdjustmentRecord s) { }

		[Address(RVA = "0x18B3AB0", Offset = "0x18B2CB0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FD")]
		internal uint <SortMarkToMarkAdjustmentRecords>b__27_1(MarkToMarkAdjustmentRecord s) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000276")]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000277")]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000278")]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000279")]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400027A")]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400027B")]
	internal Dictionary<UInt32, List`1<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400027C")]
	internal Dictionary<UInt32, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400027D")]
	internal Dictionary<UInt32, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400027E")]
	internal Dictionary<UInt32, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; //Field offset: 0x50

	[Token(Token = "0x1700008E")]
	public List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EC")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002ED")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008D")]
	public List<LigatureSubstitutionRecord> ligatureRecords
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EA")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008F")]
	public List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EE")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002EF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000090")]
	public List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F0")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008C")]
	public List<MultipleSubstitutionRecord> multipleSubstitutionRecords
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E9")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x18A2200", Offset = "0x18A1400", Length = "0x265")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGlyphAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpgradeGlyphAdjustmentTableToFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60002F2")]
	public TMP_FontFeatureTable() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EC")]
	public List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EA")]
	public List<LigatureSubstitutionRecord> get_ligatureRecords() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EE")]
	public List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002F0")]
	public List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E8")]
	public List<MultipleSubstitutionRecord> get_multipleSubstitutionRecords() { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002ED")]
	public void set_glyphPairAdjustmentRecords(List<GlyphPairAdjustmentRecord> value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EB")]
	public void set_ligatureRecords(List<LigatureSubstitutionRecord> value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EF")]
	public void set_MarkToBaseAdjustmentRecords(List<MarkToBaseAdjustmentRecord> value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002F1")]
	public void set_MarkToMarkAdjustmentRecords(List<MarkToMarkAdjustmentRecord> value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E9")]
	public void set_multipleSubstitutionRecords(List<MultipleSubstitutionRecord> value) { }

	[Address(RVA = "0x18A1B40", Offset = "0x18A0D40", Length = "0x23C")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortAllTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, System.UInt32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.List`1<TSource>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F3")]
	public void SortGlyphPairAdjustmentRecords() { }

	[Address(RVA = "0x18A1D80", Offset = "0x18A0F80", Length = "0x23C")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortAllTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<TMPro.MarkToBaseAdjustmentRecord>)}, ReturnType = typeof(System.Collections.Generic.List`1<TMPro.MarkToBaseAdjustmentRecord>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F4")]
	public void SortMarkToBaseAdjustmentRecords() { }

	[Address(RVA = "0x18A1FC0", Offset = "0x18A11C0", Length = "0x23C")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortAllTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<TMPro.MarkToMarkAdjustmentRecord>)}, ReturnType = typeof(System.Collections.Generic.List`1<TMPro.MarkToMarkAdjustmentRecord>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F5")]
	public void SortMarkToMarkAdjustmentRecords() { }

}

