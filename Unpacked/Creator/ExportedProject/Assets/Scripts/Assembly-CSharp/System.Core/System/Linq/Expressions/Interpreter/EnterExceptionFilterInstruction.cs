namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E5")]
internal sealed class EnterExceptionFilterInstruction : Instruction
{
	[Token(Token = "0x40001DA")]
	internal static readonly EnterExceptionFilterInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x1700014D")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1596BA0", Offset = "0x1595DA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000567")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700014E")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000568")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1596B30", Offset = "0x1595D30", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600056A")]
	private static EnterExceptionFilterInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000566")]
	private EnterExceptionFilterInstruction() { }

	[Address(RVA = "0x1596BA0", Offset = "0x1595DA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000567")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000568")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000569")]
	public virtual int Run(InterpretedFrame frame) { }

}

