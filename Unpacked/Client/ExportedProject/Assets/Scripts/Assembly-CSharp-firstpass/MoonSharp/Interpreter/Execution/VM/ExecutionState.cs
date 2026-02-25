namespace MoonSharp.Interpreter.Execution.VM;

[Token(Token = "0x200014A")]
internal sealed class ExecutionState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000502")]
	public FastStack<DynValue> ValueStack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000503")]
	public FastStack<CallStackItem> ExecutionStack; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000504")]
	public int InstructionPtr; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000505")]
	public CoroutineState State; //Field offset: 0x24

	[Address(RVA = "0x3568B0", Offset = "0x355AB0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FastStack`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C2D")]
	public ExecutionState() { }

}

