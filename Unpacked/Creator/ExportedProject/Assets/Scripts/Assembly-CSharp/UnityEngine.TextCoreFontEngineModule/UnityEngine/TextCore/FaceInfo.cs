namespace UnityEngine.TextCore;

[Token(Token = "0x2000002")]
[UsedByNativeCode]
public struct FaceInfo
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("faceIndex")]
	[SerializeField]
	[Token(Token = "0x4000001")]
	private int m_FaceIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("familyName")]
	[SerializeField]
	[Token(Token = "0x4000002")]
	private string m_FamilyName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("styleName")]
	[SerializeField]
	[Token(Token = "0x4000003")]
	private string m_StyleName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("pointSize")]
	[SerializeField]
	[Token(Token = "0x4000004")]
	private float m_PointSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("scale")]
	[SerializeField]
	[Token(Token = "0x4000005")]
	private float m_Scale; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("unitsPerEM")]
	[SerializeField]
	[Token(Token = "0x4000006")]
	private int m_UnitsPerEM; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[NativeName("lineHeight")]
	[SerializeField]
	[Token(Token = "0x4000007")]
	private float m_LineHeight; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[NativeName("ascentLine")]
	[SerializeField]
	[Token(Token = "0x4000008")]
	private float m_AscentLine; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[NativeName("capLine")]
	[SerializeField]
	[Token(Token = "0x4000009")]
	private float m_CapLine; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[NativeName("meanLine")]
	[SerializeField]
	[Token(Token = "0x400000A")]
	private float m_MeanLine; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[NativeName("baseline")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	private float m_Baseline; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[NativeName("descentLine")]
	[SerializeField]
	[Token(Token = "0x400000C")]
	private float m_DescentLine; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[NativeName("superscriptOffset")]
	[SerializeField]
	[Token(Token = "0x400000D")]
	private float m_SuperscriptOffset; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[NativeName("superscriptSize")]
	[SerializeField]
	[Token(Token = "0x400000E")]
	private float m_SuperscriptSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[NativeName("subscriptOffset")]
	[SerializeField]
	[Token(Token = "0x400000F")]
	private float m_SubscriptOffset; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[NativeName("subscriptSize")]
	[SerializeField]
	[Token(Token = "0x4000010")]
	private float m_SubscriptSize; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[NativeName("underlineOffset")]
	[SerializeField]
	[Token(Token = "0x4000011")]
	private float m_UnderlineOffset; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[NativeName("underlineThickness")]
	[SerializeField]
	[Token(Token = "0x4000012")]
	private float m_UnderlineThickness; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[NativeName("strikethroughOffset")]
	[SerializeField]
	[Token(Token = "0x4000013")]
	private float m_StrikethroughOffset; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[NativeName("strikethroughThickness")]
	[SerializeField]
	[Token(Token = "0x4000014")]
	private float m_StrikethroughThickness; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[NativeName("tabWidth")]
	[SerializeField]
	[Token(Token = "0x4000015")]
	private float m_TabWidth; //Field offset: 0x5C

	[Token(Token = "0x17000008")]
	public float ascentLine
	{
		[Address(RVA = "0x1A1E290", Offset = "0x1A1D490", Length = "0x8")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 25)]
		[Token(Token = "0x600000A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	public float baseline
	{
		[Address(RVA = "0x19DC170", Offset = "0x19DB370", Length = "0x8")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000009")]
	public float capLine
	{
		[Address(RVA = "0x19DC160", Offset = "0x19DB360", Length = "0x8")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000B")]
		 get { } //Length: 8
		[Address(RVA = "0x1888A50", Offset = "0x1887C50", Length = "0x6")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000C")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000C")]
	public float descentLine
	{
		[Address(RVA = "0x18756A0", Offset = "0x18748A0", Length = "0x8")]
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000010")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000001")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal int faceIndex
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000001")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public string familyName
	{
		[Address(RVA = "0x150E210", Offset = "0x150D410", Length = "0x7")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000002")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000007")]
	public float lineHeight
	{
		[Address(RVA = "0x1979DA0", Offset = "0x1978FA0", Length = "0x8")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000009")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000A")]
	public float meanLine
	{
		[Address(RVA = "0x19DC120", Offset = "0x19DB320", Length = "0x8")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000D")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000004")]
	public float pointSize
	{
		[Address(RVA = "0x2C0D70", Offset = "0x2BFF70", Length = "0x8")]
		[CallerCount(Count = 61)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000004")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000005")]
	public float scale
	{
		[Address(RVA = "0x2C0B00", Offset = "0x2BFD00", Length = "0x8")]
		[CallerCount(Count = 66)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000005")]
		 get { } //Length: 8
		[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000013")]
	public float strikethroughOffset
	{
		[Address(RVA = "0x1A1E2A0", Offset = "0x1A1D4A0", Length = "0x8")]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000017")]
		 get { } //Length: 8
		[Address(RVA = "0x18F05B0", Offset = "0x18EF7B0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000018")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000003")]
	public string styleName
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000003")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700000F")]
	public float subscriptOffset
	{
		[Address(RVA = "0x1A1E2B0", Offset = "0x1A1D4B0", Length = "0x8")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000013")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000010")]
	public float subscriptSize
	{
		[Address(RVA = "0x1A1E2C0", Offset = "0x1A1D4C0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000014")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000D")]
	public float superscriptOffset
	{
		[Address(RVA = "0x1875550", Offset = "0x1874750", Length = "0x8")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000011")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000E")]
	public float superscriptSize
	{
		[Address(RVA = "0x19DC110", Offset = "0x19DB310", Length = "0x8")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000012")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000014")]
	public float tabWidth
	{
		[Address(RVA = "0x1A1E2D0", Offset = "0x1A1D4D0", Length = "0x8")]
		[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000019")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000011")]
	public float underlineOffset
	{
		[Address(RVA = "0x1A1E2E0", Offset = "0x1A1D4E0", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000015")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000012")]
	public float underlineThickness
	{
		[Address(RVA = "0x1A1E2F0", Offset = "0x1A1D4F0", Length = "0x8")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000016")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000006")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal int unitsPerEM
	{
		[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000007")]
		internal get { } //Length: 6
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000008")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x1A1E290", Offset = "0x1A1D490", Length = "0x8")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 25)]
	[Token(Token = "0x600000A")]
	public float get_ascentLine() { }

	[Address(RVA = "0x19DC170", Offset = "0x19DB370", Length = "0x8")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public float get_baseline() { }

	[Address(RVA = "0x19DC160", Offset = "0x19DB360", Length = "0x8")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public float get_capLine() { }

	[Address(RVA = "0x18756A0", Offset = "0x18748A0", Length = "0x8")]
	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	public float get_descentLine() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000001")]
	internal int get_faceIndex() { }

	[Address(RVA = "0x150E210", Offset = "0x150D410", Length = "0x7")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000002")]
	public string get_familyName() { }

	[Address(RVA = "0x1979DA0", Offset = "0x1978FA0", Length = "0x8")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public float get_lineHeight() { }

	[Address(RVA = "0x19DC120", Offset = "0x19DB320", Length = "0x8")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public float get_meanLine() { }

	[Address(RVA = "0x2C0D70", Offset = "0x2BFF70", Length = "0x8")]
	[CallerCount(Count = 61)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public float get_pointSize() { }

	[Address(RVA = "0x2C0B00", Offset = "0x2BFD00", Length = "0x8")]
	[CallerCount(Count = 66)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public float get_scale() { }

	[Address(RVA = "0x1A1E2A0", Offset = "0x1A1D4A0", Length = "0x8")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000017")]
	public float get_strikethroughOffset() { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public string get_styleName() { }

	[Address(RVA = "0x1A1E2B0", Offset = "0x1A1D4B0", Length = "0x8")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public float get_subscriptOffset() { }

	[Address(RVA = "0x1A1E2C0", Offset = "0x1A1D4C0", Length = "0x8")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	public float get_subscriptSize() { }

	[Address(RVA = "0x1875550", Offset = "0x1874750", Length = "0x8")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000011")]
	public float get_superscriptOffset() { }

	[Address(RVA = "0x19DC110", Offset = "0x19DB310", Length = "0x8")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public float get_superscriptSize() { }

	[Address(RVA = "0x1A1E2D0", Offset = "0x1A1D4D0", Length = "0x8")]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000019")]
	public float get_tabWidth() { }

	[Address(RVA = "0x1A1E2E0", Offset = "0x1A1D4E0", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000015")]
	public float get_underlineOffset() { }

	[Address(RVA = "0x1A1E2F0", Offset = "0x1A1D4F0", Length = "0x8")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000016")]
	public float get_underlineThickness() { }

	[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	internal int get_unitsPerEM() { }

	[Address(RVA = "0x1888A50", Offset = "0x1887C50", Length = "0x6")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	public void set_capLine(float value) { }

	[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public void set_meanLine(float value) { }

	[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public void set_scale(float value) { }

	[Address(RVA = "0x18F05B0", Offset = "0x18EF7B0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000018")]
	public void set_strikethroughOffset(float value) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	internal void set_unitsPerEM(int value) { }

}

