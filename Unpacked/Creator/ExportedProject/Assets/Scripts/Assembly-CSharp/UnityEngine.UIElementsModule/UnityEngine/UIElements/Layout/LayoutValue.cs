namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005EB")]
internal struct LayoutValue
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001597")]
	private float value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001598")]
	private LayoutUnit unit; //Field offset: 0x4

	[Token(Token = "0x17000A87")]
	public LayoutUnit Unit
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002996")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000A88")]
	public float Value
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002997")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1BAF260", Offset = "0x1BAE460", Length = "0x16")]
	[CalledBy(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600299D")]
	public static LayoutValue Auto() { }

	[Address(RVA = "0x1BAF370", Offset = "0x1BAE570", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002999")]
	public bool Equals(LayoutValue other) { }

	[Address(RVA = "0x1BAF280", Offset = "0x1BAE480", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600299A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002996")]
	public LayoutUnit get_Unit() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002997")]
	public float get_Value() { }

	[Address(RVA = "0x1BAF3D0", Offset = "0x1BAE5D0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x600299B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1BAF430", Offset = "0x1BAE630", Length = "0x23")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600299F")]
	public static LayoutValue op_Implicit(float value) { }

	[Address(RVA = "0x1BAF400", Offset = "0x1BAE600", Length = "0x28")]
	[CalledBy(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600299E")]
	public static LayoutValue Percent(float value) { }

	[Address(RVA = "0x1BAF430", Offset = "0x1BAE630", Length = "0x23")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002998")]
	public static LayoutValue Point(float value) { }

	[Address(RVA = "0x1BAF460", Offset = "0x1BAE660", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600299C")]
	public static LayoutValue Undefined() { }

}

