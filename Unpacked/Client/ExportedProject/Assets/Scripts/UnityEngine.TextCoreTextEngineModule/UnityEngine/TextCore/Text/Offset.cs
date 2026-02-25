namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000052")]
internal struct Offset
{
	[Token(Token = "0x40002FE")]
	private static readonly Offset k_ZeroOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002FA")]
	private float m_Left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002FB")]
	private float m_Right; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002FC")]
	private float m_Top; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40002FD")]
	private float m_Bottom; //Field offset: 0xC

	[Token(Token = "0x17000069")]
	public float bottom
	{
		[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000208")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000066")]
	public float left
	{
		[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000205")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000067")]
	public float right
	{
		[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000206")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000068")]
	public float top
	{
		[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000207")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700006A")]
	public static Offset zero
	{
		[Address(RVA = "0x1A5A080", Offset = "0x1A59280", Length = "0x60")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000209")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x1A5A040", Offset = "0x1A59240", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600020F")]
	private static Offset() { }

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020A")]
	public Offset(float left, float right, float top, float bottom) { }

	[Address(RVA = "0x1A59F90", Offset = "0x1A59190", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600020E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000208")]
	public float get_bottom() { }

	[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000205")]
	public float get_left() { }

	[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000206")]
	public float get_right() { }

	[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000207")]
	public float get_top() { }

	[Address(RVA = "0x1A5A080", Offset = "0x1A59280", Length = "0x60")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000209")]
	public static Offset get_zero() { }

	[Address(RVA = "0x1A59FF0", Offset = "0x1A591F0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x600020D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1825420", Offset = "0x1824620", Length = "0x38")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600020B")]
	public static bool op_Equality(Offset lhs, Offset rhs) { }

	[Address(RVA = "0x1943940", Offset = "0x1942B40", Length = "0x47")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020C")]
	public static Offset op_Multiply(Offset a, float b) { }

}

