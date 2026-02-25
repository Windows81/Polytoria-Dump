namespace UnityEngine.UIElements;

[Token(Token = "0x20002F6")]
internal struct FilterParameter : IEquatable<FilterParameter>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000C07")]
	private FilterParameterType m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000C08")]
	private float m_FloatValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000C09")]
	private Color m_ColorValue; //Field offset: 0x8

	[Token(Token = "0x17000449")]
	public Color colorValue
	{
		[Address(RVA = "0xCE38B0", Offset = "0xCE2AB0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600151B")]
		 get { } //Length: 11
		[Address(RVA = "0x1474EB0", Offset = "0x14740B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600151C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000448")]
	public float floatValue
	{
		[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001519")]
		 get { } //Length: 6
		[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x600151A")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000447")]
	public FilterParameterType type
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001517")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001518")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x1AD9660", Offset = "0x1AD8860", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600151F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1AD97A0", Offset = "0x1AD89A0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001520")]
	public override bool Equals(FilterParameter other) { }

	[Address(RVA = "0xCE38B0", Offset = "0xCE2AB0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600151B")]
	public Color get_colorValue() { }

	[Address(RVA = "0x553AD0", Offset = "0x552CD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001519")]
	public float get_floatValue() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001517")]
	public FilterParameterType get_type() { }

	[Address(RVA = "0x1AD9860", Offset = "0x1AD8A60", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001521")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1AD99C0", Offset = "0x1AD8BC0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600151D")]
	public static bool op_Equality(FilterParameter a, FilterParameter b) { }

	[Address(RVA = "0x1AD9A50", Offset = "0x1AD8C50", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600151E")]
	public static bool op_Inequality(FilterParameter a, FilterParameter b) { }

	[Address(RVA = "0x1474EB0", Offset = "0x14740B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600151C")]
	public void set_colorValue(Color value) { }

	[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600151A")]
	public void set_floatValue(float value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001518")]
	public void set_type(FilterParameterType value) { }

	[Address(RVA = "0x1AD9930", Offset = "0x1AD8B30", Length = "0x90")]
	[CalledBy(Type = typeof(FilterFunction), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E29EF0")]
	[Token(Token = "0x6001522")]
	public virtual string ToString() { }

}

