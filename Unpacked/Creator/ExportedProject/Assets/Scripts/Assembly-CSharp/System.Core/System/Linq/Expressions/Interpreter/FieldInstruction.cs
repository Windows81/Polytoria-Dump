namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000123")]
internal abstract class FieldInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021D")]
	protected readonly FieldInfo _field; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000609")]
	public FieldInstruction(FieldInfo field) { }

	[Address(RVA = "0x15A2570", Offset = "0x15A1770", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600060A")]
	public virtual string ToString() { }

}

