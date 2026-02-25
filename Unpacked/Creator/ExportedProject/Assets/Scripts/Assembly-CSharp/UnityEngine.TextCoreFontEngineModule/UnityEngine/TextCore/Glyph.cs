namespace UnityEngine.TextCore;

[Token(Token = "0x2000006")]
[UsedByNativeCode]
public class Glyph
{
	[FieldOffset(Offset = "0x10")]
	[NativeName("index")]
	[SerializeField]
	[Token(Token = "0x4000026")]
	private uint m_Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[NativeName("metrics")]
	[SerializeField]
	[Token(Token = "0x4000027")]
	private GlyphMetrics m_Metrics; //Field offset: 0x14
	[FieldOffset(Offset = "0x28")]
	[NativeName("glyphRect")]
	[SerializeField]
	[Token(Token = "0x4000028")]
	private GlyphRect m_GlyphRect; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[NativeName("scale")]
	[SerializeField]
	[Token(Token = "0x4000029")]
	private float m_Scale; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[NativeName("atlasIndex")]
	[SerializeField]
	[Token(Token = "0x400002A")]
	private int m_AtlasIndex; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[NativeName("type")]
	[SerializeField]
	[Token(Token = "0x400002B")]
	private GlyphClassDefinitionType m_ClassDefinitionType; //Field offset: 0x40

	[Token(Token = "0x17000023")]
	public int atlasIndex
	{
		[Address(RVA = "0x1A23920", Offset = "0x1A22B20", Length = "0x6")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextProcessingElement[]"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextLib", Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo", "UnityEngine.TextCore.NativeTextGenerationSettings"}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x6000035")]
		 get { } //Length: 6
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public GlyphRect glyphRect
	{
		[Address(RVA = "0x19A8C90", Offset = "0x19A7E90", Length = "0xB")]
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000031")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000032")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700001F")]
	public uint index
	{
		[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
		[CallerCount(Count = 58)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		 get { } //Length: 6
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000020")]
	public GlyphMetrics metrics
	{
		[Address(RVA = "0x1A234D0", Offset = "0x1A226D0", Length = "0x11")]
		[CallerCount(Count = 40)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		 get { } //Length: 17
		[Address(RVA = "0x1A23930", Offset = "0x1A22B30", Length = "0xE")]
		[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int), typeof(Sprite)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000030")]
		 set { } //Length: 14
	}

	[Token(Token = "0x17000022")]
	public float scale
	{
		[Address(RVA = "0x18756A0", Offset = "0x18748A0", Length = "0x8")]
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000033")]
		 get { } //Length: 8
		[Address(RVA = "0x1A23940", Offset = "0x1A22B40", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000034")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x1A238E0", Offset = "0x1A22AE0", Length = "0x33")]
	[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int), typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.SpriteGlyph", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000037")]
	public Glyph() { }

	[Address(RVA = "0x1A23820", Offset = "0x1A22A20", Length = "0x49")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	internal Glyph(GlyphMarshallingStruct glyphStruct) { }

	[Address(RVA = "0x1A23870", Offset = "0x1A22A70", Length = "0x64")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	[Address(RVA = "0x1A23920", Offset = "0x1A22B20", Length = "0x6")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextProcessingElement[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextLib", Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo", "UnityEngine.TextCore.NativeTextGenerationSettings"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x6000035")]
	public int get_atlasIndex() { }

	[Address(RVA = "0x19A8C90", Offset = "0x19A7E90", Length = "0xB")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000031")]
	public GlyphRect get_glyphRect() { }

	[Address(RVA = "0x195F0B0", Offset = "0x195E2B0", Length = "0x6")]
	[CallerCount(Count = 58)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public uint get_index() { }

	[Address(RVA = "0x1A234D0", Offset = "0x1A226D0", Length = "0x11")]
	[CallerCount(Count = 40)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	public GlyphMetrics get_metrics() { }

	[Address(RVA = "0x18756A0", Offset = "0x18748A0", Length = "0x8")]
	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	public float get_scale() { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public void set_atlasIndex(int value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	public void set_glyphRect(GlyphRect value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public void set_index(uint value) { }

	[Address(RVA = "0x1A23930", Offset = "0x1A22B30", Length = "0xE")]
	[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int), typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000030")]
	public void set_metrics(GlyphMetrics value) { }

	[Address(RVA = "0x1A23940", Offset = "0x1A22B40", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000034")]
	public void set_scale(float value) { }

}

