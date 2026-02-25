namespace UnityEngine.TextCore;

[Token(Token = "0x2000004")]
[UsedByNativeCode]
public struct GlyphRect : IEquatable<GlyphRect>
{
	[Token(Token = "0x4000020")]
	private static readonly GlyphRect s_ZeroGlyphRect; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeName("x")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	private int m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("y")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	private int m_Y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("width")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	private int m_Width; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("height")]
	[SerializeField]
	[Token(Token = "0x400001F")]
	private int m_Height; //Field offset: 0xC

	[Token(Token = "0x17000018")]
	public int height
	{
		[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
		[CallerCount(Count = 119)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000017")]
	public int width
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000015")]
	public int x
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000016")]
	public int y
	{
		[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
		[CallerCount(Count = 54)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000019")]
	public static GlyphRect zero
	{
		[Address(RVA = "0x1A23670", Offset = "0x1A22870", Length = "0x60")]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x1A23630", Offset = "0x1A22830", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000023")]
	private static GlyphRect() { }

	[Address(RVA = "0x1828760", Offset = "0x1827960", Length = "0x12")]
	[CallerCount(Count = 24)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	public GlyphRect(int x, int y, int width, int height) { }

	[Address(RVA = "0x1A23580", Offset = "0x1A22780", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A23500", Offset = "0x1A22700", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	public override bool Equals(GlyphRect other) { }

	[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
	[CallerCount(Count = 119)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001D")]
	public int get_height() { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	public int get_width() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001A")]
	public int get_x() { }

	[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001B")]
	public int get_y() { }

	[Address(RVA = "0x1A23670", Offset = "0x1A22870", Length = "0x60")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600001E")]
	public static GlyphRect get_zero() { }

	[Address(RVA = "0x1A235E0", Offset = "0x1A227E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000020")]
	public virtual int GetHashCode() { }

}

