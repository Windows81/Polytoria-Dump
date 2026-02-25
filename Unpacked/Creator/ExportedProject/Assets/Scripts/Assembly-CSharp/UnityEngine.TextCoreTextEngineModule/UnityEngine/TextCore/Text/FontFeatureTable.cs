namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200001E")]
public class FontFeatureTable
{
	[CompilerGenerated]
	[Token(Token = "0x200001F")]
	private sealed class <>c
	{
		[Token(Token = "0x4000090")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000091")]
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__24_0; //Field offset: 0x8
		[Token(Token = "0x4000092")]
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__24_1; //Field offset: 0x10
		[Token(Token = "0x4000093")]
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__25_0; //Field offset: 0x18
		[Token(Token = "0x4000094")]
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__25_1; //Field offset: 0x20
		[Token(Token = "0x4000095")]
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__26_0; //Field offset: 0x28
		[Token(Token = "0x4000096")]
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__26_1; //Field offset: 0x30

		[Address(RVA = "0x1A3B990", Offset = "0x1A3AB90", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000041")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000042")]
		public <>c() { }

		[Address(RVA = "0x18B39D0", Offset = "0x18B2BD0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		internal uint <SortGlyphPairAdjustmentRecords>b__24_0(GlyphPairAdjustmentRecord s) { }

		[Address(RVA = "0x18B3A10", Offset = "0x18B2C10", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000044")]
		internal uint <SortGlyphPairAdjustmentRecords>b__24_1(GlyphPairAdjustmentRecord s) { }

		[Address(RVA = "0x1A3B940", Offset = "0x1A3AB40", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000045")]
		internal uint <SortMarkToBaseAdjustmentRecords>b__25_0(MarkToBaseAdjustmentRecord s) { }

		[Address(RVA = "0x1A3B960", Offset = "0x1A3AB60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000046")]
		internal uint <SortMarkToBaseAdjustmentRecords>b__25_1(MarkToBaseAdjustmentRecord s) { }

		[Address(RVA = "0x1A3B940", Offset = "0x1A3AB40", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000047")]
		internal uint <SortMarkToMarkAdjustmentRecords>b__26_0(MarkToMarkAdjustmentRecord s) { }

		[Address(RVA = "0x1A3B960", Offset = "0x1A3AB60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000048")]
		internal uint <SortMarkToMarkAdjustmentRecords>b__26_1(MarkToMarkAdjustmentRecord s) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000088")]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000089")]
	private List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400008A")]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400008B")]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400008C")]
	internal Dictionary<UInt32, List`1<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400008D")]
	internal Dictionary<UInt32, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400008E")]
	internal Dictionary<UInt32, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400008F")]
	internal Dictionary<UInt32, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; //Field offset: 0x50

	[Token(Token = "0x17000008")]
	internal List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003A")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	internal List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords
	{
		[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003B")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x1700000A")]
	internal List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords
	{
		[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003C")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x1A33600", Offset = "0x1A32800", Length = "0x265")]
	[CalledBy(Type = typeof(FontAsset), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x600003D")]
	internal FontFeatureTable() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	internal List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	internal List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003C")]
	internal List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	[Address(RVA = "0x1A32F40", Offset = "0x1A32140", Length = "0x23C")]
	[CalledBy(Type = typeof(FontAsset), Member = "SortFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "SortAllTables", ReturnType = typeof(void))]
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
	[Token(Token = "0x600003E")]
	public void SortGlyphPairAdjustmentRecords() { }

	[Address(RVA = "0x1A33180", Offset = "0x1A32380", Length = "0x23C")]
	[CalledBy(Type = typeof(FontAsset), Member = "SortFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "SortAllTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600003F")]
	public void SortMarkToBaseAdjustmentRecords() { }

	[Address(RVA = "0x1A333C0", Offset = "0x1A325C0", Length = "0x23C")]
	[CalledBy(Type = typeof(FontAsset), Member = "SortFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "SortAllTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000040")]
	public void SortMarkToMarkAdjustmentRecords() { }

}

