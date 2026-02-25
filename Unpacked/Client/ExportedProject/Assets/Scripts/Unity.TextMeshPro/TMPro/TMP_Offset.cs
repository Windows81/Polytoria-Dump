namespace TMPro;

[Token(Token = "0x200002E")]
public struct TMP_Offset
{
	[Token(Token = "0x400013F")]
	private static readonly TMP_Offset k_ZeroOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013B")]
	private float m_Left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400013C")]
	private float m_Right; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400013D")]
	private float m_Top; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400013E")]
	private float m_Bottom; //Field offset: 0xC

	[Token(Token = "0x1700003D")]
	public float bottom
	{
		[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000160")]
		 get { } //Length: 6
		[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000161")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700003E")]
	public float horizontal
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000162")]
		 get { } //Length: 5
		[Address(RVA = "0x1824360", Offset = "0x1823560", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000163")]
		 set { } //Length: 10
	}

	[Token(Token = "0x1700003A")]
	public float left
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015A")]
		 get { } //Length: 5
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015B")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700003B")]
	public float right
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015C")]
		 get { } //Length: 6
		[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015D")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700003C")]
	public float top
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015E")]
		 get { } //Length: 6
		[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700003F")]
	public float vertical
	{
		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000164")]
		 get { } //Length: 6
		[Address(RVA = "0x189E0A0", Offset = "0x189D2A0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000165")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000040")]
	public static TMP_Offset zero
	{
		[Address(RVA = "0x189DF70", Offset = "0x189D170", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000166")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x189DF10", Offset = "0x189D110", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600016F")]
	private static TMP_Offset() { }

	[Address(RVA = "0x189DF50", Offset = "0x189D150", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000168")]
	public TMP_Offset(float horizontal, float vertical) { }

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000167")]
	public TMP_Offset(float left, float right, float top, float bottom) { }

	[Address(RVA = "0x189DE60", Offset = "0x189D060", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600016D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x189DDE0", Offset = "0x189CFE0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600016E")]
	public bool Equals(TMP_Offset other) { }

	[Address(RVA = "0x564B90", Offset = "0x563D90", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000160")]
	public float get_bottom() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000162")]
	public float get_horizontal() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015A")]
	public float get_left() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015C")]
	public float get_right() { }

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015E")]
	public float get_top() { }

	[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000164")]
	public float get_vertical() { }

	[Address(RVA = "0x189DF70", Offset = "0x189D170", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000166")]
	public static TMP_Offset get_zero() { }

	[Address(RVA = "0x189DEC0", Offset = "0x189D0C0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x600016C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1825420", Offset = "0x1824620", Length = "0x38")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000169")]
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	[Address(RVA = "0x189DFD0", Offset = "0x189D1D0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600016A")]
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	[Address(RVA = "0x189E080", Offset = "0x189D280", Length = "0x11")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600016B")]
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000161")]
	public void set_bottom(float value) { }

	[Address(RVA = "0x1824360", Offset = "0x1823560", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000163")]
	public void set_horizontal(float value) { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015B")]
	public void set_left(float value) { }

	[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015D")]
	public void set_right(float value) { }

	[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015F")]
	public void set_top(float value) { }

	[Address(RVA = "0x189E0A0", Offset = "0x189D2A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000165")]
	public void set_vertical(float value) { }

}

