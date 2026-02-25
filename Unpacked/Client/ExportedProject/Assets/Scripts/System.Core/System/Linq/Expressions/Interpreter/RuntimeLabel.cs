namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
[Token(Token = "0x20000D3")]
internal struct RuntimeLabel
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001BC")]
	public readonly int Index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001BD")]
	public readonly int StackDepth; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001BE")]
	public readonly int ContinuationStackDepth; //Field offset: 0x8

	[Address(RVA = "0x15A8030", Offset = "0x15A7230", Length = "0xB")]
	[CalledBy(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
	[CalledBy(Type = typeof(InstructionList), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60004F8")]
	public RuntimeLabel(int index, int continuationStackDepth, int stackDepth) { }

	[Address(RVA = "0x15A7F50", Offset = "0x15A7150", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60004F9")]
	public virtual string ToString() { }

}

