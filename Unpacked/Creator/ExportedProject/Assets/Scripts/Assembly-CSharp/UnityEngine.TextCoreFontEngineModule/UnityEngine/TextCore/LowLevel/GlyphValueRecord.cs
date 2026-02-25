namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000011")]
[UsedByNativeCode]
public struct GlyphValueRecord : IEquatable<GlyphValueRecord>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("xPlacement")]
	[SerializeField]
	[Token(Token = "0x4000084")]
	private float m_XPlacement; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("yPlacement")]
	[SerializeField]
	[Token(Token = "0x4000085")]
	private float m_YPlacement; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("xAdvance")]
	[SerializeField]
	[Token(Token = "0x4000086")]
	private float m_XAdvance; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("yAdvance")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	private float m_YAdvance; //Field offset: 0xC

	[Token(Token = "0x17000026")]
	public float xAdvance
	{
		[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008A")]
		 get { } //Length: 8
		[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008B")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000024")]
	public float xPlacement
	{
		[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000086")]
		 get { } //Length: 7
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000087")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000027")]
	public float yAdvance
	{
		[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000025")]
	public float yPlacement
	{
		[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000088")]
		 get { } //Length: 8
		[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000089")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008D")]
	public GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	[Address(RVA = "0x1A236D0", Offset = "0x1A228D0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000090")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A23730", Offset = "0x1A22930", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000091")]
	public override bool Equals(GlyphValueRecord other) { }

	[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008A")]
	public float get_xAdvance() { }

	[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000086")]
	public float get_xPlacement() { }

	[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008C")]
	public float get_yAdvance() { }

	[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000088")]
	public float get_yPlacement() { }

	[Address(RVA = "0x1A237B0", Offset = "0x1A229B0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x600008F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A23800", Offset = "0x1A22A00", Length = "0x13")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008E")]
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008B")]
	public void set_xAdvance(float value) { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000087")]
	public void set_xPlacement(float value) { }

	[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000089")]
	public void set_yPlacement(float value) { }

}

