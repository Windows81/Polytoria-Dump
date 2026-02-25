namespace UnityEngine.TextCore.LowLevel;

[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
[Token(Token = "0x2000013")]
[UsedByNativeCode]
public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("firstAdjustmentRecord")]
	[SerializeField]
	[Token(Token = "0x400008A")]
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[NativeName("secondAdjustmentRecord")]
	[SerializeField]
	[Token(Token = "0x400008B")]
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; //Field offset: 0x14
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400008C")]
	private FontFeatureLookupFlags m_FeatureLookupFlags; //Field offset: 0x28

	[Token(Token = "0x1700002C")]
	public FontFeatureLookupFlags featureLookupFlags
	{
		[Address(RVA = "0xFE9850", Offset = "0xFE8A50", Length = "0x96C")]
		[CallerCount(Count = 33)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "System.Threading.ThreadLocal`1+IdManager", Member = "GetId", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_method_get_class")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600009B")]
		 get { } //Length: 2412
	}

	[Token(Token = "0x1700002A")]
	public GlyphAdjustmentRecord firstAdjustmentRecord
	{
		[Address(RVA = "0x1A234C0", Offset = "0x1A226C0", Length = "0x10")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateGlyphAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_GlyphPairAdjustmentRecord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontFeatureTable+<>c", Member = "<SortGlyphPairAdjustmentRecords>b__25_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(uint))]
		[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable+<>c", Member = "<SortGlyphPairAdjustmentRecords>b__24_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(uint))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 14)]
		[Token(Token = "0x6000098")]
		 get { } //Length: 16
		[Address(RVA = "0x1A234F0", Offset = "0x1A226F0", Length = "0xD")]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000099")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002B")]
	public GlyphAdjustmentRecord secondAdjustmentRecord
	{
		[Address(RVA = "0x1A234D0", Offset = "0x1A226D0", Length = "0x11")]
		[CallerCount(Count = 40)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009A")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x1A23490", Offset = "0x1A22690", Length = "0x23")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpgradeGlyphAdjustmentTableToFontFeatureTable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600009C")]
	public GlyphPairAdjustmentRecord(GlyphAdjustmentRecord firstAdjustmentRecord, GlyphAdjustmentRecord secondAdjustmentRecord) { }

	[Address(RVA = "0x1A232E0", Offset = "0x1A224E0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x600009E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A23360", Offset = "0x1A22560", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x600009F")]
	public override bool Equals(GlyphPairAdjustmentRecord other) { }

	[Address(RVA = "0xFE9850", Offset = "0xFE8A50", Length = "0x96C")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[Calls(Type = "System.Threading.ThreadLocal`1+IdManager", Member = "GetId", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_method_get_class")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600009B")]
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	[Address(RVA = "0x1A234C0", Offset = "0x1A226C0", Length = "0x10")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateGlyphAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_GlyphPairAdjustmentRecord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontFeatureTable+<>c", Member = "<SortGlyphPairAdjustmentRecords>b__25_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable+<>c", Member = "<SortGlyphPairAdjustmentRecords>b__24_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 14)]
	[Token(Token = "0x6000098")]
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	[Address(RVA = "0x1A234D0", Offset = "0x1A226D0", Length = "0x11")]
	[CallerCount(Count = 40)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009A")]
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	[Address(RVA = "0x1A23420", Offset = "0x1A22620", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[ExcludeFromDocs]
	[Token(Token = "0x600009D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A234F0", Offset = "0x1A226F0", Length = "0xD")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000099")]
	public void set_firstAdjustmentRecord(GlyphAdjustmentRecord value) { }

}

