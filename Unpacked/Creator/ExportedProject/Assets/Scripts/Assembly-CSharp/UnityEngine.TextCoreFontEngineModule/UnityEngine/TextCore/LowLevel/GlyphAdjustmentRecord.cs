namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000012")]
[UsedByNativeCode]
public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("glyphIndex")]
	[SerializeField]
	[Token(Token = "0x4000088")]
	private uint m_GlyphIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("glyphValueRecord")]
	[SerializeField]
	[Token(Token = "0x4000089")]
	private GlyphValueRecord m_GlyphValueRecord; //Field offset: 0x4

	[Token(Token = "0x17000028")]
	public uint glyphIndex
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000092")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000029")]
	public GlyphValueRecord glyphValueRecord
	{
		[Address(RVA = "0x1A23140", Offset = "0x1A22340", Length = "0xB")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_GlyphAdjustmentRecord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphAdjustmentRecord)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_GlyphPairAdjustmentRecord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 15)]
		[Token(Token = "0x6000093")]
		 get { } //Length: 11
	}

	[Address(RVA = "0xCE3310", Offset = "0xCE2510", Length = "0xB")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000094")]
	public GlyphAdjustmentRecord(uint glyphIndex, GlyphValueRecord glyphValueRecord) { }

	[Address(RVA = "0x1A23070", Offset = "0x1A22270", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000096")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A22FE0", Offset = "0x1A221E0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000097")]
	public override bool Equals(GlyphAdjustmentRecord other) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000092")]
	public uint get_glyphIndex() { }

	[Address(RVA = "0x1A23140", Offset = "0x1A22340", Length = "0xB")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_GlyphAdjustmentRecord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphAdjustmentRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_GlyphPairAdjustmentRecord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 15)]
	[Token(Token = "0x6000093")]
	public GlyphValueRecord get_glyphValueRecord() { }

	[Address(RVA = "0x1A230E0", Offset = "0x1A222E0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000095")]
	public virtual int GetHashCode() { }

}

