namespace MoonSharp.Interpreter.Tree.Statements;

[Token(Token = "0x2000092")]
internal class FunctionCallStatement : Statement
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F0")]
	private FunctionCallExpression m_FunctionCallExpression; //Field offset: 0x20

	[Address(RVA = "0x31EF20", Offset = "0x31E120", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600072C")]
	public FunctionCallStatement(ScriptLoadingContext lcontext, FunctionCallExpression functionCallExpression) { }

	[Address(RVA = "0x31EDD0", Offset = "0x31DFD0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ByteCode), Member = "EnterSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(ByteCode), Member = "Emit_Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600072D")]
	public virtual void Compile(ByteCode bc) { }

	[Address(RVA = "0x31EEF0", Offset = "0x31E0F0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600072E")]
	private void RemoveBreakpointStop(Instruction instruction) { }

}

