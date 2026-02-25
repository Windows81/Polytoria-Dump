namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200020A")]
internal sealed class DupInstruction : Instruction
{
	[Token(Token = "0x400038B")]
	internal static readonly DupInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x170001FB")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15D1C60", Offset = "0x15D0E60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60009D0")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001FA")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009CF")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x15D1BF0", Offset = "0x15D0DF0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009D2")]
	private static DupInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CE")]
	private DupInstruction() { }

	[Address(RVA = "0x15D1C60", Offset = "0x15D0E60", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60009D0")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009CF")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x15D1BC0", Offset = "0x15D0DC0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Dup", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009D1")]
	public virtual int Run(InterpretedFrame frame) { }

}

