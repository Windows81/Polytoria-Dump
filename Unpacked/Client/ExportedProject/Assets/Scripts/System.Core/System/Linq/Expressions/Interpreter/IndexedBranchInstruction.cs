namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000DD")]
internal abstract class IndexedBranchInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CE")]
	internal readonly int _labelIndex; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000534")]
	public IndexedBranchInstruction(int labelIndex) { }

	[Address(RVA = "0x15A3F90", Offset = "0x15A3190", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000535")]
	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	[Address(RVA = "0x15A3FF0", Offset = "0x15A31F0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000536")]
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

	[Address(RVA = "0x15A40B0", Offset = "0x15A32B0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000537")]
	public virtual string ToString() { }

}

