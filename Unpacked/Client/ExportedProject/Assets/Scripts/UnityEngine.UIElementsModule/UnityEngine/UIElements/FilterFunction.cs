namespace UnityEngine.UIElements;

[Token(Token = "0x20002F7")]
internal struct FilterFunction : IEquatable<FilterFunction>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000C0A")]
	private FilterFunctionType m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000C0B")]
	private FixedBuffer4<FilterParameter> m_Parameters; //Field offset: 0x4
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x4000C0C")]
	private int m_ParameterCount; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000C0D")]
	private FilterFunctionDefinition m_CustomDefinition; //Field offset: 0x68

	[Token(Token = "0x1700044C")]
	public int parameterCount
	{
		[Address(RVA = "0x5215D0", Offset = "0x5207D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001525")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700044B")]
	internal FixedBuffer4<FilterParameter> parameters
	{
		[Address(RVA = "0x1AD9480", Offset = "0x1AD8680", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001524")]
		internal get { } //Length: 51
	}

	[Token(Token = "0x1700044A")]
	public FilterFunctionType type
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001523")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x1AD8EE0", Offset = "0x1AD80E0", Length = "0x211")]
	[CalledBy(Type = typeof(FilterFunction), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABDB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001528")]
	public override bool Equals(FilterFunction other) { }

	[Address(RVA = "0x1AD8E00", Offset = "0x1AD8000", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(FilterFunction), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterFunction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001529")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5215D0", Offset = "0x5207D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001525")]
	public int get_parameterCount() { }

	[Address(RVA = "0x1AD9480", Offset = "0x1AD8680", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001524")]
	internal FixedBuffer4<FilterParameter> get_parameters() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001523")]
	public FilterFunctionType get_type() { }

	[Address(RVA = "0x1AD9100", Offset = "0x1AD8300", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FilterFunctionDefinitionUtils), Member = "GetBuiltinDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterFunctionType)}, ReturnType = typeof(FilterFunctionDefinition))]
	[Token(Token = "0x6001526")]
	internal FilterFunctionDefinition GetDefinition() { }

	[Address(RVA = "0x1AD9120", Offset = "0x1AD8320", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600152A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1AD94C0", Offset = "0x1AD86C0", Length = "0x197")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABDB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001527")]
	public static bool op_Equality(FilterFunction lhs, FilterFunction rhs) { }

	[Address(RVA = "0x1AD9230", Offset = "0x1AD8430", Length = "0x241")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FilterFunctionDefinitionUtils), Member = "GetBuiltinDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterFunctionType)}, ReturnType = typeof(FilterFunctionDefinition))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(FilterParameter), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600152B")]
	public virtual string ToString() { }

}

