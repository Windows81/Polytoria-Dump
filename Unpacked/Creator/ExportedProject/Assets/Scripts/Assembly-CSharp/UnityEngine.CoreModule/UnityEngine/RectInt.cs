namespace UnityEngine;

[Token(Token = "0x2000098")]
[UsedByNativeCode]
public struct RectInt : IEquatable<RectInt>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C9")]
	private int m_XMin; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001CA")]
	private int m_YMin; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001CB")]
	private int m_Width; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001CC")]
	private int m_Height; //Field offset: 0xC

	[Token(Token = "0x17000082")]
	public int height
	{
		[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
		[CallerCount(Count = 119)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FD")]
		 get { } //Length: 6
		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000081")]
	public int width
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FB")]
		 get { } //Length: 6
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700007F")]
	public int x
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F7")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F8")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000085")]
	public int xMax
	{
		[Address(RVA = "0x193AAD0", Offset = "0x1939CD0", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000301")]
		 get { } //Length: 100
	}

	[Token(Token = "0x17000083")]
	public int xMin
	{
		[Address(RVA = "0x193AB40", Offset = "0x1939D40", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x60002FF")]
		 get { } //Length: 100
	}

	[Token(Token = "0x17000080")]
	public int y
	{
		[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
		[CallerCount(Count = 54)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F9")]
		 get { } //Length: 6
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000086")]
	public int yMax
	{
		[Address(RVA = "0x193ABB0", Offset = "0x1939DB0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000302")]
		 get { } //Length: 101
	}

	[Token(Token = "0x17000084")]
	public int yMin
	{
		[Address(RVA = "0x193AC20", Offset = "0x1939E20", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000300")]
		 get { } //Length: 101
	}

	[Token(Token = "0x17000087")]
	public static RectInt zero
	{
		[Address(RVA = "0x40E930", Offset = "0x40DB30", Length = "0xD")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000304")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x1828760", Offset = "0x1827960", Length = "0x12")]
	[CallerCount(Count = 24)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000303")]
	public RectInt(int xMin, int yMin, int width, int height) { }

	[Address(RVA = "0x193A780", Offset = "0x1939980", Length = "0x27")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600030C")]
	public override bool Equals(RectInt other) { }

	[Address(RVA = "0x193A6C0", Offset = "0x19398C0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600030B")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0xE25210", Offset = "0xE24410", Length = "0x6")]
	[CallerCount(Count = 119)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FD")]
	public int get_height() { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FB")]
	public int get_width() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002F7")]
	public int get_x() { }

	[Address(RVA = "0x193AAD0", Offset = "0x1939CD0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000301")]
	public int get_xMax() { }

	[Address(RVA = "0x193AB40", Offset = "0x1939D40", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x60002FF")]
	public int get_xMin() { }

	[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002F9")]
	public int get_y() { }

	[Address(RVA = "0x193ABB0", Offset = "0x1939DB0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000302")]
	public int get_yMax() { }

	[Address(RVA = "0x193AC20", Offset = "0x1939E20", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000300")]
	public int get_yMin() { }

	[Address(RVA = "0x40E930", Offset = "0x40DB30", Length = "0xD")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000304")]
	public static RectInt get_zero() { }

	[Address(RVA = "0x193A7B0", Offset = "0x19399B0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600030A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x193AC90", Offset = "0x1939E90", Length = "0x27")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000309")]
	public static bool op_Equality(RectInt lhs, RectInt rhs) { }

	[Address(RVA = "0x193ACC0", Offset = "0x1939EC0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000308")]
	public static bool op_Inequality(RectInt lhs, RectInt rhs) { }

	[Address(RVA = "0x191B090", Offset = "0x191A290", Length = "0xA11")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000305")]
	public bool Overlaps(RectInt other) { }

	[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FE")]
	public void set_height(int value) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FC")]
	public void set_width(int value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002F8")]
	public void set_x(int value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FA")]
	public void set_y(int value) { }

	[Address(RVA = "0x193AAC0", Offset = "0x1939CC0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18191B330")]
	[Token(Token = "0x6000306")]
	public virtual string ToString() { }

	[Address(RVA = "0x193A850", Offset = "0x1939A50", Length = "0x26B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000307")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

