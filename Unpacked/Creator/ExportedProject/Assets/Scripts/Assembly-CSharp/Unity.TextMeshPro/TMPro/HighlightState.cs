namespace TMPro;

[Token(Token = "0x200002F")]
public struct HighlightState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000140")]
	public Color32 color; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000141")]
	public TMP_Offset padding; //Field offset: 0x4

	[Address(RVA = "0xCE3310", Offset = "0xCE2510", Length = "0xB")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000170")]
	public HighlightState(Color32 color, TMP_Offset padding) { }

	[Address(RVA = "0x1889360", Offset = "0x1888560", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000174")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x18893D0", Offset = "0x18885D0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000175")]
	public bool Equals(HighlightState other) { }

	[Address(RVA = "0x1889460", Offset = "0x1888660", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000173")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x18894C0", Offset = "0x18886C0", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000171")]
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	[Address(RVA = "0x1889600", Offset = "0x1888800", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000172")]
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

}

