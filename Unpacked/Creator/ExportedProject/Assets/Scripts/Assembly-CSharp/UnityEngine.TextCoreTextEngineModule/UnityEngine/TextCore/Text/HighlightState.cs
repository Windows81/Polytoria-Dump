namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000053")]
internal struct HighlightState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002FF")]
	public Color32 color; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000300")]
	public Offset padding; //Field offset: 0x4

	[Address(RVA = "0xCE3310", Offset = "0xCE2510", Length = "0xB")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000210")]
	public HighlightState(Color32 color, Offset padding) { }

	[Address(RVA = "0x1A59B90", Offset = "0x1A58D90", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000214")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A59C00", Offset = "0x1A58E00", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000213")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A59C60", Offset = "0x1A58E60", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000211")]
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	[Address(RVA = "0x1A59DA0", Offset = "0x1A58FA0", Length = "0x13C")]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000212")]
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

}

