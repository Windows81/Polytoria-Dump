namespace UnityEngine.TextCore;

[Token(Token = "0x2000005")]
[UsedByNativeCode]
public struct GlyphMetrics : IEquatable<GlyphMetrics>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("width")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private float m_Width; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("height")]
	[SerializeField]
	[Token(Token = "0x4000022")]
	private float m_Height; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("horizontalBearingX")]
	[SerializeField]
	[Token(Token = "0x4000023")]
	private float m_HorizontalBearingX; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("horizontalBearingY")]
	[SerializeField]
	[Token(Token = "0x4000024")]
	private float m_HorizontalBearingY; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("horizontalAdvance")]
	[SerializeField]
	[Token(Token = "0x4000025")]
	private float m_HorizontalAdvance; //Field offset: 0x10

	[Token(Token = "0x1700001B")]
	public float height
	{
		[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000025")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001E")]
	public float horizontalAdvance
	{
		[Address(RVA = "0x2C0D80", Offset = "0x2BFF80", Length = "0x8")]
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000028")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001C")]
	public float horizontalBearingX
	{
		[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000026")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001D")]
	public float horizontalBearingY
	{
		[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000027")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001A")]
	public float width
	{
		[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000024")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1A232B0", Offset = "0x1A224B0", Length = "0x25")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000029")]
	public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance) { }

	[Address(RVA = "0x1A231E0", Offset = "0x1A223E0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A23150", Offset = "0x1A22350", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	public override bool Equals(GlyphMetrics other) { }

	[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000025")]
	public float get_height() { }

	[Address(RVA = "0x2C0D80", Offset = "0x2BFF80", Length = "0x8")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000028")]
	public float get_horizontalAdvance() { }

	[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000026")]
	public float get_horizontalBearingX() { }

	[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000027")]
	public float get_horizontalBearingY() { }

	[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000024")]
	public float get_width() { }

	[Address(RVA = "0x1A23250", Offset = "0x1A22450", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x600002A")]
	public virtual int GetHashCode() { }

}

